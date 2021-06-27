using System;
using System.Data;
using System.Data.SqlClient;

namespace SVRMSDataLayer
{
    public class SVRMSSQLData
    {
       

        static string connectionstring
            = "Data Source=DESKTOP-B37C92R;Initial Catalog=SVRMSConnection;Integrated Security=True";
        static SqlConnection sqlconnection = new SqlConnection(connectionstring);

        public static void Connect()
        {
            sqlconnection.Open();
        }

        static public void AddInputViolation(string studentnumber, string name, int yearlevel, 
            string section, string adviser, string violation, string typeofviolation, string offense)
        {
            var InputStatement = "INSERT INTO SVRMSTbl " +
                "(StudentNumber, StudentName, StudentLevel, StudentSection, StudentAdviser, Violation, TypeOfViolation, Offense) " +
                "VALUES (@StudentNumber, @StudentName, @StudentLevel, @StudentSection, @StudentAdviser, @Violation, @TypeOfViolation, @Offense )";
            SqlCommand inputCommand = new SqlCommand(InputStatement, sqlconnection);
            inputCommand.Parameters.AddWithValue("@StudentNumber", studentnumber);
            inputCommand.Parameters.AddWithValue("@StudentName", name);
            inputCommand.Parameters.AddWithValue("@StudentLevel", yearlevel);
            inputCommand.Parameters.AddWithValue("@StudentSection", section);
            inputCommand.Parameters.AddWithValue("@StudentAdviser", adviser);
            inputCommand.Parameters.AddWithValue("@Violation", violation);
            inputCommand.Parameters.AddWithValue("@TypeOfViolation", typeofviolation);
            inputCommand.Parameters.AddWithValue("@Offense", offense);
            sqlconnection.Open();
            inputCommand.ExecuteNonQuery();
            sqlconnection.Close();

            Console.WriteLine("Successfully recorded");
        }
        public static void ShowData()
        {
            SqlCommand selectData;

            // Create the sql command
            selectData = sqlconnection.CreateCommand();

            // Declare the sript of sql command
            selectData.CommandText = "SELECT StudentNumber, StudentName, StudentLevel, StudentSection, StudentAdviser," +
                " Violation, TypeOfViolation, Offense FROM SVRMSTbl";
            sqlconnection.Open();
            // Declare a reader, through which we will read the data.
            SqlDataReader rdr = selectData.ExecuteReader();

            // Read the data
            while (rdr.Read())
            {
                string studentnumber = (string)rdr["StudentNumber"];
                string studentname = (string)rdr["StudentName"];
                int studentlevel = (int)rdr["StudentLevel"];
                string studentsection = (string)rdr["StudentSection"];
                string studentadviser = (string)rdr["StudentAdviser"];
                string violation = (string)rdr["Violation"];
                string typeofviolation = (string)rdr["TypeOfViolation"];
                string offense = (string)rdr["Offense"];

                // Print the data.
                
                Console.WriteLine(studentnumber + "\t||" + studentname + "\t||" + studentlevel + "\t||" + studentsection + 
                    "\t||" + studentadviser + "\t||" + violation + "\t||" + typeofviolation + "\t||" + offense);
            }

            rdr.Close();
            sqlconnection.Close();
        }

      
            
        }
       
    
    


}
