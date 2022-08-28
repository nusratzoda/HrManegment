namespace Infrastructure.Servicess;
using Domain.Models;
public class RoleService
{
    private List<Role> roles = new List<Role>();
    public List<Role> GetRoles()
    {
        return roles;
    }
    public void Add(Role employee)
    {
        roles.Add(employee);
    }
    public void Update(Role role, int id)
    {
        var search = roles.Find(x => x.Id == id);
        search.Id = role.Id;
        search.Name = role.Name;
        search.Description = role.Description;
        search.EmployeeId = role.EmployeeId;
    }
      public void Delete(int id)
    {
        var search = roles.Find(x=>x.Id == id);
        roles.Remove(search);
    }
      public int Count()
    {
        int cnt = roles.Count();
        return cnt;
    }
}