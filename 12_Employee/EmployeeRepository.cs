using System.Collections.Generic;
using System.Linq;

namespace _12_Employee
{
    public class EmployeeRepository
    {
        List<Employee> employeeList = new List<Employee>();
        int id = 0;

        public void Clear()
        {
            employeeList.Clear();
        }

        public int CountEmployees()
        {
            return employeeList.Count;
        }

        public Employee CreateEmployee(string name, string type)
        {
            id++;
            employeeList.Add(new Employee(name, type, id));
            return new Employee(name, type, id);
        }

        public void SaveEmployee(Employee employee)
        {
            int currentIndex = employee.Id - 1;

            employeeList[employee.Id - 1].Name = employee.Name;
            employeeList[employee.Id - 1].Type = employee.Type;
        }

        public Employee LoadEmployee(int id)
        {
            return employeeList.Where(employee => employee.Id == id).FirstOrDefault();
        }

        public List<Employee> FindAllEmployees()
        {
            return employeeList;
        }
    }
}