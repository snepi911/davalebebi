namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(
            id: 101,
            firstName: "Giorgi",
            lastName: "Beridze",
            age: 20,
            personalId: "01024085912",
            email: "giorgi.beridze@university.edu.ge",
            phoneNumber: "555123456",
            faculty: "Computer Science",
            course: 2,
            gpa: 3.75
        );

            Console.WriteLine();
            student1.PrintFullInfo();
        }
    }
}
