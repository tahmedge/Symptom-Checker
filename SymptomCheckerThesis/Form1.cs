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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Proceed_Click(object sender, EventArgs e)
        {

            string s1 = textBox_no_of_symptoms.Text.ToString();
            if (String.IsNullOrEmpty(s1))
            {
               MessageBox.Show("You must enter at least one symptom");
            }
            else
            {

                int i, flag = 0; ;
                for (i = 0; i < s1.Length; i++)
                {
                    if (s1[i] > '9' || s1[i] < '0')
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)
                {
                    MessageBox.Show("Only numbers from 0-9 are allowed");
                }
                else
                {
                    Data.total_no_of_symptoms = Convert.ToInt32(s1);
                    Form2 ob = new Form2();
                    this.Hide();
                    ob.Show();
                }
            }

        }
    }
}
