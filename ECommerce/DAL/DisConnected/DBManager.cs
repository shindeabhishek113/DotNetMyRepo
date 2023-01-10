namespace DAL.DisConnected;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;



public class DBManager
{

    public static string conString = @"server=localhost;port=3306;user=root; password=root123;database=transflower";
    public static List<Department> GetAllDepartments()
    {
        List<Department> allDepartments = new List<Department>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            DataSet ds = new DataSet();  //empty data set
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string query = "SELECT * FROM departments";
            cmd.CommandText = query;
            //disconnected Data Access logic
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);  // this method would fetch data from backend mysql and 
                          //fill results into dataset collection
                          //deal with data which has been fetched from back end

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                int id = int.Parse(row["id"].ToString());
                string name = row["name"].ToString();
                string location = row["location"].ToString();
                Department dept = new Department
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
                allDepartments.Add(dept);
            }
        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        return allDepartments;
    }


    public static List<Employee> GetAllEmployees()
    {

        List<Employee> allEmployees = new List<Employee>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            DataSet ds = new DataSet();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;

            string query = "SELECT * FROM employees";

            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRowCollection rows = dt.Rows;

            foreach (DataRow row in rows)
            {

                int id = int.Parse(row["id"].ToString());
                string firstname = row["firstname"].ToString();
                string lastname = row["lastname"].ToString();
                string email = row["email"].ToString();
                string address = row["address"].ToString();
                string password = row["password"].ToString();
                int deptid = int.Parse(row["deptid"].ToString());
                int managerid = int.Parse(row["managerid"].ToString());


                Employee emp = new Employee
                {

                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    Address = address,
                    Password = password,
                    DeptId = deptid,
                    ManagerId = managerid

                };
                //Call Constructor
                // Employee emp= new Employee(id, firstname,lastname)
                // {
                //     Id = id,
                //     FirstName = firstname,
                //     LastName = lastname
                // };
                allEmployees.Add(emp);

            }

        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        return allEmployees;


    }



    public static List<Employee> GetAllEmployeesByDept(int id)
    {

        List<Employee> employeesbydept = new List<Employee>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            DataSet ds = new DataSet();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;
            Console.WriteLine("inEMp cont");

            string query = "SELECT * FROM employees WHERE deptid="+id;

            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRowCollection rows = dt.Rows;

            foreach (DataRow row in rows)
            {

                int id1 = int.Parse(row["id"].ToString());
                string firstname = row["firstname"].ToString();
                string lastname = row["lastname"].ToString();
                // string email = row["email"].ToString();
                // string address = row["address"].ToString();
                // string password = row["password"].ToString();
                // int deptid = int.Parse(row["deptid"].ToString());
                // int managerid = int.Parse(row["managerid"].ToString());


                Employee emp = new Employee
                {

                    Id = id1,  
                    FirstName = firstname,
                    LastName = lastname,
                    // Email = email,
                    // Address = address,
                    // Password = password,
                    // DeptId = deptid,
                    // ManagerId = managerid

                };
                // Employee emp= new Employee(id1, firstname,lastname)
                // {
                //     Id = id1,
                //     FirstName = firstname,
                //     LastName = lastname
                // };
                Console.WriteLine("inEMp cont");
                employeesbydept.Add(emp);

            }

        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        return employeesbydept;


    }
}


//

//DisConnected Data Access Mode
//MySqlConnection  : establishing connection
//MySqlCommand      : query execution
//MySqlDataApater
//DataSet
//DataTable
//DataRow
//DataColumn
//DataRealtion
