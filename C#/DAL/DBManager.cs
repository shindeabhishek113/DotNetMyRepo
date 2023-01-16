namespace DAL;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

public class DBManager
{

    public static string conString = @"server=localhost;user=root;password=root123;database=transflower";

    public static List<Products> GetAllProducts(){

        List<Products> allProducts = new List<Products>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString=conString;
        try{

            string query = "SELECT * FROM products";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read()){

                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                int price = int.Parse(reader["price"].ToString());

                Products prod = new Products{
                    Id=id,
                    Name=name,
                    Price=price
                };
                allProducts.Add(prod);
            }
           

        }
        catch(Exception e){
         Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }

        return allProducts;
    }

    public static List<Products> GetOneProduct(int id){

      
        List<Products> getOneProd = new List<Products>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString=conString;

        try{
            string query="SELECT * FROM products WHERE id="+id;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read()){

                int id1 = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                int price = int.Parse(reader["price"].ToString());


                Products prod = new Products{
                    Id=id1,
                    Name=name,
                    Price=price
                };
                getOneProd.Add(prod);

            }
            
        }

        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }

        return getOneProd;


    }

    public static void InsertProduct(Products prod){

        MySqlConnection con = new MySqlConnection();

        con.ConnectionString=conString;

        try{

            // string query =$"insert into products(id,name,price) values('{prod.Id}','{prod.Name}','{prod.Price}'";

            // string query = "INSERT INTO products(id,name)" +
            //                 "VALUES('" + prod.Id + "','" + prod.Name + "')";
            string query = $"INSERT INTO products(id,name,price) VALUES('{prod.Id}','{prod.Name}','{prod.Price}')";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
    }



public static void DeleteProduct(int id){

        MySqlConnection con = new MySqlConnection();

        con.ConnectionString=conString;

        try{

           string query="DELETE FROM products WHERE id="+id;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
    }

    public static void UpdateProduct(int id){

        MySqlConnection con = new MySqlConnection();

        con.ConnectionString=conString;

        try{

           string query="UPDATE products SET price=300 WHERE id="+id;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
    }





    //  public  static List<Department> GetAllDepartments(){
    //         List<Department> allDepartments=new List<Department>();
    //         //database connectivity code
    //         //Connected Data Access Mode
    //         //MySqlConnection  : establishing connection
    //         //MySqlCommand      : query execution
    //         //MySqlDataReader   : result of query to be catured after processing query
    //         MySqlConnection con=new MySqlConnection();
    //         con.ConnectionString=conString;
    //         try{
    //             con.Open();
    //             //fire query to databases
    //             MySqlCommand cmd=new MySqlCommand();
    //             cmd.Connection=con;
    //             string query="SELECT * FROM departments";
    //             cmd.CommandText=query;
    //             MySqlDataReader reader=cmd.ExecuteReader();
    //             while(reader.Read()){
    //                 int id = int.Parse(reader["id"].ToString());
    //                 string name = reader["name"].ToString();
    //                 string location = reader["location"].ToString();

    //                 Department dept=new Department{
    //                                                 Id = id,
    //                                                 Name = name,
    //                                                 Location = location
    //                 };
    //                 allDepartments.Add(dept);
    //             }
    //         }
    //         catch(Exception ee){
    //             Console.WriteLine(ee.Message);
    //         }
    //         finally{
    //                 con.Close();
    //         }

    //         return allDepartments;
    // }

}
