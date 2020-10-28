using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_Redux
{
    public partial class FusionWindow : Form
    {
        Persona m_result;

        static string path = null;
        static SQLiteConnection connection = new SQLiteConnection();
        static DbAccess lastAccess = new DbAccess(path, connection);

        public FusionWindow(){}

        public FusionWindow(Persona result)
        {
            this.m_result = result;
            InitializeComponent();
            SetLabels();
            TableView.View = View.Details;
            SetUpTableView();
            StartFusion();

        }


       
        private void FusionWindow_Load(object sender, EventArgs e)
        {
            
        }


        private void StartFusion()
        {
            List<string> resultpairs = new List<string>();
            string text;
            Fusion fusison = new Fusion(m_result);

             resultpairs = Fusion.StartFusion(m_result);


             DisplayResults(resultpairs);
        }

        private void DisplayResults(List<string> resultpairs)
        {
            
            string first;
            string second;
            Persona firstPersona;
            Persona secondPersona;
            char split = Convert.ToChar(":");
            


            for (int i = 0; i < resultpairs.Count; i++)
            {

                //Gets each Persona Name and pulls up their information
                string[] arr = resultpairs.ElementAt(i).Split(split);

                first = arr.ElementAt(0);
                second = arr.ElementAt(1);

                firstPersona = lastAccess.GetSinglePersona(connection, first);
                secondPersona = lastAccess.GetSinglePersona(connection, second);

                AddtoView(firstPersona, secondPersona);
            }



            for (int i = 0; i < TableView.Columns.Count; i++)
            {
                if (i == 2 || i == 5)
                {
                    TableView.Columns[i].Width = -2;
                }
                else
                {
                    TableView.Columns[i].Width = -1;
                }

            }

        }



        private void AddtoView(Persona first, Persona second)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            
                    //First Persona 

                    lvi = new ListViewItem();
                    lvi.Text = first.m_name;


                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = first.m_arcana;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = first.m_level.ToString();
                    lvi.SubItems.Add(lvsi);

                    //Second Persona

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = second.m_name;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = second.m_arcana;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = second.m_level.ToString();
                    lvi.SubItems.Add(lvsi);

                    TableView.Items.Add(lvi);

        }







        private void SetLabels()
        {
            NameLbl.Text = m_result.m_name;
            ArcanaLbl.Text = m_result.m_arcana;
            LvLLbl.Text = m_result.m_level.ToString();
        }

        private void SetUpTableView()
        {
            //First Persona
            TableView.Columns.Add("Arcana", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Persona", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Level", -2, HorizontalAlignment.Center);


            //Second Persona
            TableView.Columns.Add("Arcana", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Persona", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Level", -2, HorizontalAlignment.Center);

        }

    }
}
