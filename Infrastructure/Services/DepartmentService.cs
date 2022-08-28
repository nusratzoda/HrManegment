namespace Infrastructure.Servicess;
using Domain.Models;
public class DepartmentService
{
    private List<Department> departments = new List<Department>();
    public List<Department> GetDepartments()
    {
        return departments;
    }
    public void Add(Department department)
    {
        departments.Add(department);
    }
    public void Update(Department department, int id)
    {
        var search = departments.Find(x => x.Id == id);
        search.Id = department.Id;
        search.Name = department.Name;
        search.Description = department.Description;
    }
    public  Department GetDepartmentById(int id)
    {
         var department = departments.Find(element => element.Id == id);
       return department;
    }
      public void Delete(int id)
    {
        var search = departments.Find(x=>x.Id == id);
        departments.Remove(search);
    }
      public int Count()
    {
        int cnt = departments.Count();
        return cnt;
    }
}