using Project.Models;
using Project.DTO.Request;


namespace Project.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        public string CreateUser(EmployeeReq employee);
        public List<Employee> GetAll();
        public bool UpdateUser(int id, EmployeeUpdateDTO employee);
        public bool DeleteUser(int id);
        public Employee GetEmployeeById(int id);
        public string DeactivateEmployee(int id);
        public void ActiveEmployee(int id);
        public bool CheckCCCDIsExist(string cccd);
    }
}
