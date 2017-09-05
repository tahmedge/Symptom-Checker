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
    public partial class Form2 : Form
    {
     //   int val;
        public Form2()
        {
            InitializeComponent();
            int val = Data.current_position_of_symptom;
            val++;
            textBlock_enter_symptom.Text = "Enter Symptom " +val.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_proceed_Click(object sender, EventArgs e)
        {

            string s1 = textBox_symptomname.Text.ToString();
            s1 = s1.ToLower();
            int i;
            if (String.IsNullOrEmpty(s1))
            {
                MessageBox.Show("Symptom name can not be null");
              
            }
            else
            {
                Data ob = new Data();
                string[] words = s1.Split(' ');
                int value;
                Data.usertext.Add(s1);
                Data.symptom_name[Data.current_position_of_symptom] = "null";
                Data.time[Data.current_position_of_symptom] = "null";
                Data.intensity[Data.current_position_of_symptom] = "null";
                Data.organ_name[Data.current_position_of_symptom] = "null";
                Data.duration[Data.current_position_of_symptom] = "null";
                foreach (string tempword in words)
                {
                    value = 0;

                    string word=tempword;
                    value = ob.getsynonym(word);
                    if(value!=0)
                    {
                        word = ob.returnsynonym(word);
                    }
                
                    value = 0;
                    value = ob.getsymptom(word);
                    if (value!=0)
                    {
                        Data.symptom_name[Data.current_position_of_symptom] = word;
                        continue;
                    }
                    value = ob.gettime(word);
                    if (value != 0)
                    {
                        Data.time[Data.current_position_of_symptom] = word;
                        continue;
                    }
                    value = ob.getintensity(word);
                    if (value != 0)
                    {
                        Data.intensity[Data.current_position_of_symptom] = word;
                        continue;
                    }
                    value = ob.getorgan(word);
                    if (value != 0)
                    {
                        Data.organ_name[Data.current_position_of_symptom] = word;
                        continue;
                    }
                    value = ob.getduration(word);
                    if (value != 0)
                    {
                        Data.duration[Data.current_position_of_symptom] = word;
                        continue;
                    }
                    if(value==0)
                    {
                       // int val = ob.checkdecisiontree(word);
                        
                            foreach (string tempstr in words)
                            {
                            /*    if(string.Compare(tempstr, word) == 0)
                                {
                                    break;
                                }
                                else */
                                {
                                   int val = ob.checkdecisiontree(word, tempstr);
                                   if(val==1)
                                   {
                                    string str= ob.returnfromdecisiontree(word, tempstr);
                                    word = str;
                                    Data.symptom_name[Data.current_position_of_symptom] = word;
                                   // continue;
                                    break;
                                   }
                                }
                               
                            }
                        
                    }



                }

                Data.current_position_of_symptom++;
                if (Data.current_position_of_symptom == Data.total_no_of_symptoms)
                {
                    Form4 ob1 = new Form4();
                    ob1.Show();
                    this.Hide();
                }
                textBox_symptomname.Text = "";
                
                textBlock_enter_symptom.Text= "Enter Symptom " + (Data.current_position_of_symptom+1).ToString(); 
            }

        }
    }
}
