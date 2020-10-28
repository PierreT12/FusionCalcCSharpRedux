using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_Redux
{
    public class Persona
    {
        public string m_name { get; set; }
        public string m_arcana { get; set; }
        public int m_level { get; set; }
        public bool m_spoiler { get; set; }
        public bool m_fuseable { get; set; }
        public bool m_sFusion { get; set; }
        public bool m_maxSL { get; set; }
        public bool m_treasure { get; set; }

        public Persona() {}

        public Persona(string name,
                string arcana,
                int level,
                bool spoiler,
                bool fuseable,
                bool sFusion,
                bool maxSL, 
                bool treasure)
        {
            name = this.m_name;
            arcana = this.m_arcana;
            level = this.m_level;
            spoiler = this.m_spoiler;
            fuseable = this.m_fuseable;
            sFusion = this.m_sFusion;
            maxSL = this.m_maxSL;
            treasure = this.m_treasure;

        }



    }
}
