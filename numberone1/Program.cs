using numberone1;

namespace numberone1
{
    class Program
    {

        public static void Main(string[] args)
        {

            Student student = new Student ( firstName: "юля", lastName: "исаева", group: "пкс", averageMark: 4);
            
            Aspirant aspirant = new Aspirant(firstName: "я", lastName: "хочу", group: "спать", averageMark: 5, work: "часов" );
            
            Console.WriteLine("стипендия студента: " + student.getScholarship());
            Console.WriteLine("стипендия аспиранта: " + aspirant.getScholarship());
           student.PrintStudent();
            
        }
    }
}
