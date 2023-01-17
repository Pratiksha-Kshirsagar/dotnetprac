namespace connection;
using MySql.Data.MySqlClient;
using BOL;


public class DBmanager{

    public static String conString = "host=localhost; user=root; password=root; port=3306; database=endmodule";

    public static List<Student> getAll() {

        List<Student> list = new List<Student>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try{
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string query = "select * from student";
            cmd.CommandText = query;

            MySqlDataReader data = cmd.ExecuteReader();

            while(data.Read()){
                string FNAME = data["fname"].ToString();
                string LNAME = data["lname"].ToString();

                Student stu = new Student{
                    fname = FNAME,
                    lname = LNAME
                };
                list.Add(stu);
            }

        }
        catch(Exception e) {
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }

        return list;

    } 
 public static void insert(string fname,string lname) {

        //List<Student> list = new List<Student>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try{
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string query = "insert into student values('"+fname+"','"+lname+"')";
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();

        }
        catch(Exception e) {
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }


    } 


}