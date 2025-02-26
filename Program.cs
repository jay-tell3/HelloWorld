namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your first name"); //ask the user for there first name
            string FristName = Console.ReadLine(); // Changes the FirstName sring variable to what the user says
            Console.WriteLine("What is your last name"); // asks for the last name
            string LastName = Console.ReadLine(); //  Changes the FirstName sring variable to what the user says
            Console.WriteLine("Hello " + FristName + " " + LastName); // says Hello pluse what ever was put as the first and last name varib is
        }
    }
}
