namespace Infrastructure.Servicess;
using Domain.Models;
public class EmployeeService
{
    private List<Employee> employees = new List<Employee>();
    private List<Role> roles = new List<Role>();
    private List<Experience> experiences = new List<Experience>();
    public List<Employee> GetEmployees()
    {
        return employees;
    }
    public void Add(Employee employee)
    {
        employees.Add(employee);
    }
    public void Update(Employee employee, int id)
    {
        var search = employees.Find(x => x.Id == id);
        search.Id = employee.Id;
        search.FirstName = employee.FirstName;
        search.LastName = employee.LastName;
        search.BirthDate = employee.BirthDate;
        search.Adress = employee.Adress;
        search.Phone = employee.Phone;
        search.Roles = employee.Roles;
        search.Experiences = employee.Experiences;
    }
    public Employee GetEmployById(int id)
    {
        var employee = employees.Find(element => element.Id == id);
        return employee;
    }
    public Role GetRoleById(int id)
    {
        var role = roles.Find(element => element.Id == id);
        return roles;
    }

     public Experience GetExperienceById(int id)
    {
        var experience = experiences.Find(element => element.Id == id);
        return experiences;
    }
    public void Delete(int id)
    {
        var search = employees.Find(x => x.Id == id);
        employees.Remove(search);
    }
    public int Count()
    {
        int cnt = employees.Count();
        return cnt;
    }
}