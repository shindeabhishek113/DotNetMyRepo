namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conString = @"server=localhost; user=root; password=root123; database=transflower";

    public static List<Roles> GetAllRoles(){

        List<Roles> allRoles = new List<Roles>();

        MySqlConnection con = new MySqlConnection();

        con.ConnectionString=conString;

        try{
            string query="SELECT * FROM roles";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader reader = cmd.ExecuteReader();
            

            while(reader.Read()){

                int roleid = int.Parse(reader["roleid"].ToString());
                string rolename = reader["rolename"].ToString();

                Roles rol = new Roles{

                    RoleID=roleid,
                    RoleName=rolename
                };

                allRoles.Add(rol);
            }


        }catch(Exception e){
            Console.WriteLine(e.Message);

        }
        finally{
            con.Close();
        }

        return allRoles;
        
    }
    public static void InsertRoles(Roles rol){

        List<Roles> allRoles = new List<Roles>();

        MySqlConnection con = new MySqlConnection();

        con.ConnectionString=conString;

        try{
            string query=$"INSERT INTO roles (roleid,rolename) VALUES ('{rol.RoleID}','{rol.RoleName}')";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);

            cmd.ExecuteNonQuery();

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally{
            con.Close();
        }
  
    }
   

}
