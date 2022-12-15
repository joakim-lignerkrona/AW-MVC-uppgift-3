using AW_MVC_uppgift_3.Models.Entities;
using AW_MVC_uppgift_3.Views.Employees;

namespace AW_MVC_uppgift_3.Models
{
    public class DataService
    {
        private readonly EmployeeContext context;

        //List<Employee> Employees;

        string path = Environment.CurrentDirectory + @"\DataStorage\EmployeesDataSet.json";

        public DataService(EmployeeContext context)
        {
            this.context = context;


        }
        //public DataService()
        //{
        //    if(Employees == null)
        //    {
        //        try
        //        {
        //            string jsonString = File.ReadAllText(path);
        //            Employee[]? storedData = JsonSerializer.Deserialize<Employee[]>(jsonString);
        //            if(storedData != null)
        //            {
        //                Employees = storedData.ToList();

        //            }
        //            else
        //            {
        //                Employees = new List<Employee>();
        //            }
        //        }
        //        catch
        //        {

        //            Employees = new List<Employee>();
        //            saveToDisk();
        //        }
        //    }
        //}

        //void saveToDisk()
        //{
        //    string jsonString = JsonSerializer.Serialize(Employees);
        //    File.WriteAllText(path, jsonString);
        //}
        public IndexVM[] GetAll()
        {
            return context.Employees
                .Select(o => new IndexVM
                {
                    ID = o.Id,
                    Name = o.Name,
                    Email = o.Email,
                    ShowAsHighlighted = o.Email.StartsWith("admin"),
                })
                .ToArray();
        }
        public void Add(Employee employee)
        {

            //employee.Id = Employees.Count == 0 ? 1 : Employees.Max(e => e.Id) + 1;
            employee.Email = employee.Email.ToLower();
            employee.Name = employee.Name.ToLower();

            context.Employees.Add(employee);
            //saveToDisk();
            context.SaveChanges();
        }

        public Employee? GetById(int id)
        {
            return context.Employees
                .FirstOrDefault(e => e.Id == id);
        }
        public void Delete(int id)
        {
            //var index = Employees.FindIndex(x => x.Id == id);
            //Employees.RemoveAt(index);
            //saveToDisk();

            var removed = context.Remove(GetById(id));
            context.SaveChanges();
        }

    }
}
