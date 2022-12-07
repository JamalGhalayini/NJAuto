using NJAuto.Shared.Models;

namespace NJAuto.Server.Services
{
    public interface IEmployeesService
    {
        public Task AddEmployee(CreateEmployee newEmployee);
        public Task RemoveEmployee(Employee employee);
        public Task<Employee> FindEmployee(int employeeId);
        public Task<Employee> EditEmployee(Employee employee, int id);
        public Task<List<Employee>> GetEmployee();
    }
}
