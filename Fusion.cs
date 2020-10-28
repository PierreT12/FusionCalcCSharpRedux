using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_Redux
{
    class Fusion
    {
        private Persona result;

        static string path = null;
        static SQLiteConnection connection = new SQLiteConnection();
        static DbAccess fusionAccess = new DbAccess(path, connection);


        public Fusion(Persona result)
        {
            this.result = result;
        }

        

        internal static List<string> StartFusion(Persona m_result)
        {

            List<string> resultpairs = new List<string>();

            List<Persona> firstFullArcana = new List<Persona>();
            List<Persona> secondFullArcana = new List<Persona>();
            List<int> arcanaLvls = new List<int>();

            //Have to created a "MultiMap"
            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();


            arcanaLvls = fusionAccess.GetArcanaLevels(connection, m_result.m_arcana);
            

            //Gets the Pair Aracna Matches from the Database
            pairs = fusionAccess.GetPairs(connection, m_result.m_arcana);


            
            for (int i= 0; i < pairs.Count; i++)
            {
                firstFullArcana = fusionAccess.GetPersonas(connection, pairs.ElementAt(i).Key, m_result.m_name);

                for (int k = 0; k < pairs.ElementAt(i).Value.Count; k++)
                {
                    secondFullArcana = fusionAccess.GetPersonas(connection, pairs.ElementAt(i).Value.ElementAt(k), m_result.m_name);

                    //Find out how to do +=
                    resultpairs.AddRange(FusionCheck(firstFullArcana, secondFullArcana, arcanaLvls, m_result));
                }
                    
                //Returns the two Personas that will result in the Target Persona (The one the user clicked)
                
            }
            return resultpairs;


        }

        internal static List<string> SpecialFusion(Persona m_result)
        {
            List<string> specialResults = new List<string>();

            //Gets the Primary Key
            int personaSF = fusionAccess.GetPK(connection, m_result.m_name);

            //Gets a list of the results
            specialResults = fusionAccess.GetSpecialResults(connection, personaSF);


            return specialResults;
        }

        internal static List<string> StartFFusion(Persona m_result)
        {
            List<Persona> allPersonas = new List<Persona>();
            List<string> matches = new List<string>();
            string output;


            allPersonas = fusionAccess.FFGetPersonas(connection,m_result);

            for (int i = 0; i < allPersonas.Count; i++)
            {
                output = FFCheck(m_result, allPersonas.ElementAt(i));

                //Sometimes Nothing is returned so we don't wanna add
                //That to the list
                if (output != null)
                {
                    matches.Add(output);
                }
            }

            return matches;
        }

     
        private static List<string> FusionCheck(List<Persona> first, List<Persona> second, List<int> arcanaLvls, Persona m_result)
        {
            List<string> resultList = new List<string>();
            bool sameArcana;
            bool correctLevel;
            int calcLevel;
            int roundedLevel;


            for (int i = 0; i < first.Count; i++)
            {
                for (int k = 0; k < second.Count; k++)
                {
                    //This is here as a failsafe incase the query messes up
                    if (!first.ElementAt(i).m_name.Contains(second.ElementAt(k).m_name))
                    {

                        sameArcana = SamePerArcana(first.ElementAt(i), second.ElementAt(k));


                        calcLevel = CalculateLevel(first.ElementAt(i).m_level, second.ElementAt(k).m_level);

                        //Finds out what rounding to do and performs it
                        roundedLevel = RoundType(calcLevel,
                                                 sameArcana,
                                                 first.ElementAt(i),
                                                 second.ElementAt(k),
                                                 arcanaLvls);

                        //Checks that the results match the Target Persona
                        //And that the results aren't being double added
                        correctLevel = FinalCheck(roundedLevel,
                                                  m_result.m_level,
                                                  first.ElementAt(i).m_name,
                                                  second.ElementAt(k).m_name,
                                                  resultList);

                        //If everything is all good, the result is added to a list
                        if (correctLevel)
                        {
                            string str = first.ElementAt(i).m_name + ":" + second.ElementAt(k).m_name;
                            resultList.Add(str);

                        }//Correct Check
                    }//Name Check
                }//Second Arcana For Loop
            }//First Arcana For Loop



            return resultList;
        }

        private static string FFCheck(Persona m_result, Persona persona)
        {
            string resultstr = null;

            List<int> arcanaLvls = new List<int>();
            Persona outputPersona;
            bool sameArcana;
            int calcLevel;
            int roundedLevel;

            //Gets the Target Arcana if these two Arcanas are combinded
           string targetArcana = fusionAccess.GetTarget(connection,m_result.m_arcana, persona.m_arcana);

            //Do a null and empty check because sometimes there is no result
            //From GetTarget
            if (targetArcana != null) 
            {
                //Does the same thing that it does in Reverse Fusion
                arcanaLvls = fusionAccess.GetArcanaLevels(connection,targetArcana);

                sameArcana = SamePerArcana(m_result, persona);

                calcLevel = CalculateLevel(m_result.m_level, persona.m_level);

                //Finds out what rounding to do and performs it
                roundedLevel = RoundType(calcLevel,
                                         sameArcana,
                                         m_result,
                                         persona,
                                         arcanaLvls);

                //The result can be different depending on DLC Characters
                //So this check is in place to make sure it stays in line
                //With the settings the user has set
                
                    outputPersona = fusionAccess.GetResultPersona(connection, targetArcana, roundedLevel);
            

                if (outputPersona.m_name != null)
                    resultstr = persona.m_name + ":" + outputPersona.m_name;
            }
            return resultstr;
        }


        private static bool SamePerArcana(Persona first, Persona second)
        {
            bool sameArcana = false;

            if (first.m_arcana == second.m_arcana)
                sameArcana = true;
            else
                sameArcana = false;

            return sameArcana;
        }


        private static int CalculateLevel(int first, int second)
        {
            //Formula
            // RL = (lvl1 + lvl2)/2 + 0.5 or 1

            int calcLevel;
            double templevel;
            bool isfull;

            //Gets the mean of the levels
            templevel = (first + second);
            templevel /= 2;

            //Checking to see if the number is whole or not
            if (isfull = templevel % 1 == 0)
                templevel += 1;

            else
                templevel += 0.5;


            //cast it back an int
            calcLevel = (int)templevel;

            return calcLevel;
        }



        private static int RoundType(int calcLevel, bool sameArcana, Persona first, Persona second, List<int> arcanaLvls)
        {
            int roundedLevel = 0;

            if (sameArcana) //They have the same arcana
                roundedLevel = RoundDown(calcLevel,
                                         first.m_level,
                                         second.m_level,
                                         arcanaLvls);

            else //Different arcanas
                roundedLevel = RoundUp(calcLevel, arcanaLvls);


            return roundedLevel;
        }

        private static int RoundDown(int calcLevel, int first, int second, List<int> arcanaLvls)
        {
            int roundedLevel = 0;

            for (int i = 0; i < arcanaLvls.Count; i++)
            {
                if (arcanaLvls.ElementAt(i) < calcLevel &&
                   (arcanaLvls.ElementAt(i + 1) >= calcLevel))
                {
                    if (arcanaLvls.ElementAt(i) == first || arcanaLvls.ElementAt(i) == second)
                    //A Target Persona's pairing result can't include itself
                    //So it'll try to round down to the next lowest one if that's true
                    {
                        if ((i - 1) < 0) //Makes sure its not roundind down to nothing
                            break;
                        else
                        {
                            roundedLevel = arcanaLvls.ElementAt(i - 1);
                            break;
                        }
                    }// Matches a pair if statment
                    else
                    {
                        roundedLevel = arcanaLvls.ElementAt(i);
                        break;
                    }
                }// < and >= if statmennt
                else
                {
                    //A check to see if its an exact match or at the Highest index
                    if (arcanaLvls.ElementAt(i) == calcLevel ||
                       arcanaLvls.ElementAt(arcanaLvls.Count - 1) < calcLevel)
                        break;

                }
            }//Arcana Level For Loop
            return roundedLevel;
        }

        private static int RoundUp(int calcLevel, List<int> arcanaLvls)
        {
            int roundedLevel = 0;

            //Loops to tosee if the arcanaLvl is greater
            //And rounding to it if true
            for (int i = 0; i < arcanaLvls.Count; i++)
            {
                if (arcanaLvls.ElementAt(i) >= calcLevel)
                {
                    roundedLevel = arcanaLvls.ElementAt(i);
                    break;
                }
            }

            //Failsafe if there is no next highest level
            if (calcLevel >= arcanaLvls.ElementAt(arcanaLvls.Count - 1))
                roundedLevel = arcanaLvls.ElementAt(arcanaLvls.Count - 1);

            return roundedLevel;
        }

      
        private static bool FinalCheck(int roundedLevel, int realLevel, string first, string second, List<string> resultList)
        {
            bool correct = false;
            //Getting the string to make sure the reverse
            //Doesn't already exist in the correct result list
            string testStr = second + ":" + first;

            //Making sure the levels match
            correct = MathCheck(roundedLevel, realLevel );

            if (correct)
            {
                //Making sure that the same results, doesn't show up
                //ANYWHERE in the list
                for (int i = 0; i < resultList.Count; ++i)
                {
                    if (resultList.ElementAt(i).Contains(testStr))
                    {
                        correct = false;
                        break;
                    }
                    else
                        //Checks the math again for piece of mind
                        correct = MathCheck(roundedLevel, realLevel);
                }
            }
            return correct;
        }

        private static bool MathCheck(int calcLevel, int realLevel)
        {
            bool correct = false;

            if (calcLevel == realLevel)
                correct = true;
            else
                correct = false;


            return correct;
        }
    }
}
