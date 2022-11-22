using Ado.NetApp.Models;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Ado.NetApp.Repositorys
{
    public class EmployeeRepository
    {
        private readonly string _connectionString;
        private IConfiguration Configuration;

        public EmployeeRepository(IConfiguration config)
        {
            Configuration = config;
            _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }

       public IEnumerable<EmployeeData> Get()
        {
            var employees = new List<EmployeeData>();
            DataTable employeeTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {
                
                string query = "SELECT * FROM Employee2";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(employeeTable);
            }

            for(int i = 0; i < employeeTable.Rows.Count; i++)
            {
                EmployeeData emp = new EmployeeData()
                {
                    Id = (int)employeeTable.Rows[i]["Id"],
                    Name = (string)employeeTable.Rows[i]["Name"],
                    Department = (string)employeeTable.Rows[i]["Department"],
                    Salary = (int)employeeTable.Rows[i]["Salary"],

                };
                employees.Add(emp);
            }
            return employees;
        }

        public bool Post (EmployeeData emp)
        {

             using (var connection = new SqlConnection(_connectionString))
            {
                string query = $"insert into Employee2(Name,Department,Salary) values ('{emp.Name}','{emp.Department}','{emp.Salary}')";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return true;
        }

        public bool Update(EmployeeData emp,int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE Employee2 set Name='{emp.Name}',Department='{emp.Department}',Salary='{emp.Salary}' Where Id='{id}'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType= CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return true;
        }

        public bool Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = $"DELETE FROM Employee2 where Id='{id}'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return true;
        }

    }
}