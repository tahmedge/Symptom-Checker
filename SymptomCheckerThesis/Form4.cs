using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymptomCheckerThesis
{
    public partial class Form4 : Form
    {
    public static List<string> predictionlist = new List<string>();
        public Form4()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            DataTable lv = getlist();
            bs.DataSource = lv;
            dataGridView1.DataSource = bs;
            BindingSource bss = new BindingSource();
            DataTable lvv = getlist2();
            bss.DataSource = lvv;
            dataGridView2.DataSource = bss;
            // lv.Items.Add()


        }
        private DataTable getlist2()
        {
            Data ob = new Data();
            DataTable list = new DataTable();
            list.Columns.Add("User", typeof(string));
            list.Columns.Add("User Query", typeof(string));
            int tr = 0;
            foreach (string userquery in Data.usertext)
            {
                tr++;
                string s = "User " + tr.ToString();
                list.Rows.Add(s,userquery);
              
            }
            return list;

        }
        private DataTable getlist()
        {
            Data ob = new Data();
         
           
            // DataTable table = new DataTable();
            DataTable list = new DataTable();
            for (int i = 0; i < Data.total_no_of_symptoms; i++)
            {
                ob.getdiseases(Data.symptom_name[i],Data.organ_name[i]);
            //    diseaselist.
            }
            Data.diseaselist = Data.diseaselist.Distinct().ToList();
           
            int track = 0;
            list.Columns.Add("Disease name", typeof(string));
            list.Columns.Add("Probability", typeof(string));
            list.Columns.Add("Group", typeof(string));
            // list.Columns.Add("Probai")
            // list.Columns.Add("")
            foreach (string diseasename in Data.diseaselist)
            {
                double prob = 0;
                Data.diseases[track] = diseasename;
                for (int i = 0; i < Data.total_no_of_symptoms; i++)
                {
                    prob += ob.getstiod(diseasename, Data.symptom_name[i], Data.time[i], Data.intensity[i], Data.organ_name[i], Data.duration[i]);
                }
                int count = ob.noofsymptomsfordisease(diseasename);
                prob = prob / count;
                
                string cluster = "";
                if (prob <= 0.5) cluster = "L";
              
                else  if (prob > 0.50) cluster = "H";
                prob = prob * 100;
                Data.probabilityofdisease[track] = prob;
                string probability=String.Format("{0:0.00}", prob)+"%";
                list.Rows.Add(diseasename,probability,cluster);
                track++;
            }
            DataView dataview = list.DefaultView;
            dataview.Sort = "Probability desc";
            DataTable dt = dataview.ToTable();

            //  list.s
            return dt;

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
