using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace SymptomCheckerThesis
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
            BindingSource bs = new BindingSource();
            DataTable tables = GetTable();
            bs.DataSource = tables;
            dataGridView2.DataSource = bs;
           

            //  return table;
        }

        private DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Symptom", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Intensity", typeof(string));
            table.Columns.Add("Organ", typeof(string));
            table.Columns.Add("Duration", typeof(string));
            for (int i = 0; i < Data.total_no_of_symptoms; i++)
            {
                table.Rows.Add(Data.symptom_name[i], Data.time[i], Data.intensity[i], Data.organ_name[i], Data.duration[i]);
            }
            return table;
          //  throw new NotImplementedException();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            DataTable tables = GetTable();
            bs.DataSource = tables;
            dataGridView2.DataSource = bs;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
