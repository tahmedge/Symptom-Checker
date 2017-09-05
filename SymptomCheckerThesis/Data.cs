using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;




namespace SymptomCheckerThesis
{
    class Data
    {

        public static int total_no_of_symptoms = 0;
        public static int current_position_of_symptom = 0;
        public static double[] probabilityofdisease = new double[50];
        public static string[] symptom_name = new string[50];
        public static string[] time = new string[50];
        public static string[] intensity = new string[50];
        public static string[] organ_name = new string[50];
        public static string[] duration = new string[50];
        public static string[] diseases = new string[50];
        public static List<string> diseaselist = new List<string>();
        public static List<string> usertext = new List<string>();
        public int getsymptom(string symptomname)
        {
 
            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(symptom) from stiod where symptom='"+symptomname+"'";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;

        }
        public int getsynonym(string synonymmname)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(name) from synonymtree where name='" + synonymmname + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;


        }

        public int checkdecisiontree(string type,string condition)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(type) from decision_tree where type='" + type + "'and condition='" + condition + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;

        }
        public string returnfromdecisiontree(string type,string condition)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select symptomname from decision_tree where type='" + type + "'and condition='" + condition + "' ";
            OracleDataReader dr = cmd.ExecuteReader();
            //int count = Convert.ToInt32(cmd.ExecuteScalar());
            string str = "";
            while (dr.Read())
            {
                str = dr.GetString(0);
            }
            conn.Dispose();
            return str;
        }
        public string returnsynonym(string synonymmname)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select synonymname from synonymtree where name='" + synonymmname + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            //int count = Convert.ToInt32(cmd.ExecuteScalar());
            string str="";
            while (dr.Read())
            {
                str = dr.GetString(0);
            }
            conn.Dispose();
            return str;

        }
        public List<string> getdiseases(string symptomname,string organname)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select disease from stiod where symptom='" + symptomname + "' and organ= '" + organname + "'";
            OracleDataReader dr = cmd.ExecuteReader();
        //    int count = Convert.ToInt32(cmd.ExecuteScalar());
       
            int track = 0;
           // List<string> list = new List<string>();
            while(dr.Read())
            {
                diseaselist.Add(dr.GetString(0));
                track++;
            }
            conn.Dispose();
            return diseaselist;
           // return diseases;
        }
        public double getstiod(string diseasename,string symptomname,string time,string intensity, string organname,string duration)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select disease,symptom,time,intensity,organ,duration from stiod where disease = '" + diseasename + "' and symptom= '" + symptomname + "' and organ= '" + organname + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            // int count = Convert.ToInt32(cmd.ExecuteScalar());
         
            double track = 0;
            List<string> list = new List<string>();
            while (dr.Read())
            {
                double tr = 0;
                if (symptomname.Equals(dr.GetString(1)))
                {
                    tr++;
                }
                if (time.Equals(dr.GetString(2)))
                {
                    tr++;
                }
                if (intensity.Equals(dr.GetString(3)))
                {
                    tr++;
                }
                if (organname.Equals(dr.GetString(4)))
                {
                    tr++;
                }
              
                if (duration.Equals(dr.GetString(5)))
                {
                    tr++;
                }
                track += tr/ 5;
            }
       
            conn.Dispose();
            return track;
            // return diseases;
        }
        public int noofsymptomsfordisease(string diseasename)
        {
            //int val=0;
            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(disease) from stiod where disease = '" + diseasename + "' ";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
        }
        public int gettime(string time)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(time) from stiod where time='" + time + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;

        }
        public int getintensity(string intensity)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(intensity) from stiod where intensity='" + intensity + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;

        }
        public int getorgan(string organname)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(organ) from stiod where organ='" + organname + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;

        }
        public int getduration(string symptomname)
        {

            string oradb = "Data Source=localhost;User Id=system;Password=abc;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(duration) from stiod where duration='" + duration + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;

        }

    }
}
