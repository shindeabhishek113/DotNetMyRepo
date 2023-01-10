namespace BLL;
using BOL;
using DAL.DisConnected;
public class HRManager
{
    public List<Department> GetAllDepartments(){
        List<Department> allDepartments = new List<Department>();
        allDepartments=DBManager.GetAllDepartments();
        return allDepartments;
    }

    public List<Employee> GetAllEmployees(){
        List<Employee> allEmployees = new List<Employee>();
        allEmployees = DBManager.GetAllEmployees();
        return allEmployees;
    }

    public List<Employee> GetAllEmployeesByDept(int id){
        List<Employee> employeesbydept = new List<Employee>();
        employeesbydept = DBManager.GetAllEmployeesByDept(id);
        return employeesbydept;
    }



}