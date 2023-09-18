namespace Entitiyframework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDBContext();

            var emp3 = new Employee { Name = "ahmed" };
            var emp4 = new Employee { Name = "saleh" };

            _context.Employees.Add(emp3);
            _context.Employees.Add(emp4);

            _context.SaveChanges();

            var emp5 = _context.Employees.Where( x=>x.Id == 1 ).First();
            Console.WriteLine(emp5.Name);
            

            emp5.Name = "nasser";
            _context.Employees.Update(emp5);
            _context.SaveChanges();

            var emp6 = _context.Employees.First();
            Console.WriteLine(emp5.Name);

        }
    }
}