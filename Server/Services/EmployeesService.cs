using NJAuto.Server.Data;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly AppDbContext _db;

        public EmployeesService(AppDbContext db)
        {
            _db = db;
        }
        public async Task AddEmployee(CreateEmployee employee)
        {
            Employee newEmployee = new()
            {
               Username = employee.Username,
               Password = employee.Password,
               Name = employee.Name,
               LastName = employee.LastName,
            };
            await _db.AddAsync(newEmployee);
            await _db.SaveChangesAsync();
        }
        public async Task<Employee> FindEmployee(int employeeId)
        {
            if (employeeId != null)
            {
                var result = await _db.FindAsync<Employee>(employeeId);
                return result;
            }
            return null;
        }

        public async Task<Employee> EditEmployee(Employee employee, int id)
        {
            var result = await FindEmployee(id);
            if (result != null)
            {
                result.Name = employee.Name;
                result.LastName = employee.LastName;
                result.Username = employee.Username;    
                result.Password = employee.Password;    
                await _db.SaveChangesAsync();
            }
            return employee;
        }


        public async Task<List<Employee>> GetEmployee()
        {
            return await _db.employees.ToListAsync();
        }

        public async Task RemoveEmployee(Employee employee)
        {
            _db.Remove(employee);
            await _db.SaveChangesAsync();
        }
    }
}
