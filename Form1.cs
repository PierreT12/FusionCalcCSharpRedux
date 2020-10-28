using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_Redux
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = null;
            SQLiteConnection connection = new SQLiteConnection();
            DbAccess mainAccess = new DbAccess(path, connection);


            LoadPersonas(mainAccess,connection);


        }

        private void LoadPersonas(DbAccess mainAccess, SQLiteConnection connection)
        {
            List<string> list = new List<string>();
            magicBox.View = View.Details;
            StatsBox.View = View.Details;


            list = mainAccess.GetAllPersonas(connection);

            for(int i = 0; i < list.Count; i++)
            {
                personaBox.Items.Add(list.ElementAt(i));
            }

            AddMagic();
            AddStats();
        }

        private void personaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string path = null;
            SQLiteConnection connection = new SQLiteConnection();
            DbAccess mainAccess = new DbAccess(path, connection);
            List<string> stats = new List<string>();
            List<string> magic = new List<string>();

            string name = (string)personaBox.SelectedItem;

            Persona selection = mainAccess.GetSinglePersona(connection, name);
            byte[] imagebytes = mainAccess.GetImage(connection, name);
            stats = mainAccess.GetStats(connection, name);
            magic = mainAccess.GetMagic(connection, name);


            SetToDisplay(selection, imagebytes);
            SetStats(stats);
            SetMagic(magic);

        }

      

        private void SetToDisplay(Persona selection, byte[] imagebytes)
        {
            NameLbl.Text = selection.m_name;
            ArcanaLbl.Text = selection.m_arcana;
            LvLLbl.Text = selection.m_level.ToString();

            MemoryStream ms = new MemoryStream(imagebytes);
            //Doesnt like certain image formats and will error out
            displayBox.Image = Image.FromStream(ms, true);


        }


        private void AddStats()
        {
            StatsBox.Columns.Add("Stat", -2, HorizontalAlignment.Left);
            StatsBox.Columns.Add("Value", -2, HorizontalAlignment.Left);
            string[] statArr = { "Strength", "Magic", "Endureance", "Agiltiy", "Luck" };
            for (int i = 0; i < 5; i++)
            {
                StatsBox.Items.Add(statArr[i], i);
            }

        }

        private void AddMagic()
        {
            magicBox.SmallImageList = Elemental;

            magicBox.Columns.Add("Magic", -2, HorizontalAlignment.Left);
            magicBox.Columns.Add("Effect", -2, HorizontalAlignment.Left);

            /*  
             magic_View.Items.Add(lvi);*/
            for (int i = 0; i < 10; i++)
            {
                var row = new string[] { " ", "-" };
                var lvi = new ListViewItem(row);
                lvi.ImageIndex = i;
                magicBox.Items.Add(lvi);
            }
        }


        private void SetStats(List<string> stats)
        {
            StatsBox.Items.Clear();
            string[] statArr = { "Strength", "Magic", "Endureance", "Agiltiy", "Luck" };
            for (int i = 0; i < stats.Count; i++)
            {
                var row = new string[] { statArr[i], stats[i].ToString() };
                var lvi = new ListViewItem(row);
                lvi.ImageIndex = i;
                StatsBox.Items.Add(lvi);

            }


        }


        private void SetMagic(List<string> magic)
        {
            magicBox.Items.Clear();
            for (int i = 0; i < magic.Count; i++)
            {

                var row = new string[] { " ", (string)magic[i] };
                var lvi = new ListViewItem(row);
                lvi.ImageIndex = i;
                magicBox.Items.Add(lvi);

            }
        }

     
    }
}
