using MySql.Data.MySqlClient;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            string myConnectionString = "server=localhost;Port=3306;database=alacrity;uid=root;pwd=pkpk12569;"; ;

            MySqlConnection conn = new MySqlConnection(myConnectionString);

            try
            {
                conn.Open();
                //Console.WriteLine("Success!!!");

                Console.WriteLine("Connect to Database success...");


                DatabaseScript databaseScript = new DatabaseScript();

                Console.WriteLine("Clear exist table...");

                MySqlCommand cmd = new MySqlCommand(databaseScript.dropAllTable, conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Create new table...");

                cmd = new MySqlCommand(databaseScript.createDatabase, conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(databaseScript.createTableManagerInformation,conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(databaseScript.createTableCodingQuestion, conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(databaseScript.createTableCodingTestResult, conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(databaseScript.createTableCandidateInformation, conn);
                cmd.ExecuteNonQuery();


                Console.WriteLine("Start to input data...");

                for (int i = 1; i < 10; i++) {

                    TestResult example1 = new TestResult();
                    example1.id = i;
                    example1.candidate_account = "aa0000" + example1.id;
                    example1.candidate_password = "aa0000" + example1.id;
                    example1.candidate_name = "apple" + example1.id;
                    example1.email = "aa0000" + example1.id + "@bristol.ac.uk";
                    example1.phone = "+40 000 111 222" + example1.id;

                    String insert = "INSERT INTO alacrity.candidate_information values('"+example1.id+"','"+example1.candidate_account+"','"+example1.candidate_password+"'," +
                        "'"+example1.candidate_name + "','"+example1.phone+"','"+example1.email+"')";

                    cmd= new MySqlCommand(@insert,conn);
                    cmd.ExecuteNonQuery();

                }


                for(int i = 1; i < 10; i++)
                {
                    Random rnd = new Random();

                    String insert = "INSERT INTO alacrity.coding_test_result values("+i.ToString()+",'apple"+i.ToString()+"','appleName"+i.ToString()+"','" +
                        ""+DateTime.Now.ToString("yyyy/MM/dd")+"','"+DateTime.Now.ToString("HH:mm:ss")+"',"+ rnd.Next(1, 3).ToString() + "," +
                        ""+rnd.Next(50,80).ToString()+",null);";

                    cmd = new MySqlCommand(insert, conn);
                    cmd.ExecuteNonQuery();


                }


                for (int i = 1; i < 10; i++)
                {
                    Random rnd = new Random();

                    String insert = "INSERT INTO alacrity.manager_information VALUES("+i.ToString()+",'banana"+i.ToString()+"','banana"+i.ToString()+"','" +
                        "banana"+i.ToString()+"','manager','banana"+i.ToString()+"@bristol.ac.uk')";

                    cmd = new MySqlCommand(insert, conn);
                    cmd.ExecuteNonQuery();


                }



                conn.Close();

                Console.WriteLine("Finishing !!! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
