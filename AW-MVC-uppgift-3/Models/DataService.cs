using System.Text.Json;

namespace AW_MVC_uppgift_3.Models
{
    public class DataService
    {
        List<Employee> employees;

        string path = Environment.CurrentDirectory + @"\DataStorage\EmployeesDataSet.json";

        public DataService()
        {
            if(employees == null)
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    Employee[]? storedData = JsonSerializer.Deserialize<Employee[]>(jsonString);
                    if(storedData != null)
                    {
                        employees = storedData.ToList();

                    }
                    else
                    {
                        employees = new List<Employee>();
                    }
                }
                catch
                {

                    employees = new List<Employee>();
                    saveToDisk();
                }
            }
        }

        void saveToDisk()
        {
            string jsonString = JsonSerializer.Serialize(employees);
            File.WriteAllText(path, jsonString);
        }
        public Employee[] GetAll()
        {
            return employees
                .ToArray();
        }
        public void Add(Employee employee)
        {

            employee.Id = employees.Count == 0 ? 1 : employees.Max(e => e.Id) + 1;

            employees.Add(employee);
            saveToDisk();
        }

        public Employee? GetById(int id)
        {
            return employees
                .FirstOrDefault(e => e.Id == id);
        }
        public void Delete(int id)
        {
            var index = employees.FindIndex(x => x.Id == id);
            employees.RemoveAt(index);
            saveToDisk();
        }

    }
}
