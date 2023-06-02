namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("jhhgf", "ytyg", 456);
            student.Learning();
            Console.WriteLine(student.Learning);


            Teacher teacher = new Teacher("hhjs", "hhsh", 54);
            teacher.Explain();
            Console.WriteLine(teacher.Explain);

        }
    }
}