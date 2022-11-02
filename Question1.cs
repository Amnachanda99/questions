using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Qustion no 1 
            Console.WriteLine("----------Question number 1 -------------!");
            Console.WriteLine("Hello World!");
            //Question number 2 
            Console.WriteLine("----------Question number 2 -------------!");
            string firstName = "Comsat ";
            string lastName = "Lahore";
            string name = firstName + lastName;
            Console.WriteLine(name);
            //Question number 3
            Console.WriteLine("----------Question number 3 -------------!");
            const int myNum = 10;
            Console.WriteLine(myNum);
            //Question number 4
            Console.WriteLine("----------Question number 4 -------------!");
            string myName = " My name is Amna";
            string school = " i am from Punjab university";
            string degree = " And i have done my degree in computational physics";
            Console.WriteLine("Name=" + myName );
            Console.WriteLine("School=" + school);
            Console.WriteLine("Degree=" + degree);

            //Question number 5
            Console.WriteLine("----------Question number 5 -------------!");
            string yourname = "Amna Amjad";
            Console.WriteLine(yourname.ToUpper());
            Console.WriteLine(yourname.ToLower());


        }
    }
}
