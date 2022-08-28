namespace Infrastructure.Servicess;
using Domain.Models;
public class ExperienceService
{
    private List<Experience> experiences = new List<Experience>();
    public List<Experience> GetExperience()
    {
        return experiences;
    }
    public void Add(Experience experience)
    {
        experiences.Add(experience);
    }
    public void Update(Experience experience, int id)
    {
        var search = experiences.Find(x => x.Id == id);
        search.Id = experience.Id;
        search.Name = experience.Name;
        search.Description = experience.Description;
        search.Company = experience.Company;
        search.EmployeeId = experience.EmployeeId;
    }
      public void Delete(int id)
    {
        var search = experiences.Find(x=>x.Id == id);
        experiences.Remove(search);
    }
      public int Count()
    {
        int cnt = experiences.Count();
        return cnt;
    }
}