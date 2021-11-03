using System;

namespace HomeworkT2L4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 1");

            string name, surname, id;
            byte age;
            char sex;
            long workerId;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            surname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Your sex M or F?");
            sex = char.Parse(Console.ReadLine());
            Console.WriteLine("What is your Id number?");
            id = Console.ReadLine();
            Console.WriteLine("What employee number you have?");
            workerId = long.Parse(Console.ReadLine());

            Console.WriteLine($"Your data: \r\n Name: {name} \r\n Surname: {surname}");
            Console.WriteLine($"Age: {age} \r\n ID Number: {id} \r\n Employee number: {workerId}\r\n");

            ////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Program 2");

            char firstLetter;
            char secondLetter;
            char thirdLetter;

            Console.WriteLine("Enter the first letter");
            firstLetter = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second letter");
            secondLetter = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third letter");
            thirdLetter = char.Parse(Console.ReadLine());

            Console.WriteLine($"Letters in reverse {thirdLetter}{secondLetter}{firstLetter}");

            ////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Program 3");

            double l, w;

            Console.WriteLine("Enter the length of the rectangle");
            l = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            w = double.Parse(Console.ReadLine());

            double ll = Math.Pow(l, 2);
            double ww = Math.Pow(w, 2);
            double diagonal = Math.Sqrt(ll + ww);

            Console.WriteLine($"The diagonal of the rectangle is {diagonal} ");

            ///////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Program 4");

            int first = 10;
            string second = "Szkoła Dotneta";
            float third = 12.5f;

            Console.WriteLine($"First: {first}");
            Console.WriteLine($"Second: {second}");
            Console.WriteLine($"Third: {third}");

            ////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Program 5");

            string n, s, email, sex1,phone;
            byte a;
            float height, weight; 

            Console.WriteLine("What is your name?");
            n = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            s = Console.ReadLine();
            Console.WriteLine("How old are you?");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("What is your height?");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight?");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Male or female?");
            sex1 = Console.ReadLine();
            Console.WriteLine("What is your e-mail?");
            email = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            phone = Console.ReadLine();

            Console.WriteLine($"Your data: \r\n Name: {n} \r\n Surname: {s} \r\n Age: {a}");
            Console.WriteLine($"Height: {height} \r\n Weight: {weight}\r\n Sex: {sex1}");
            Console.WriteLine($"E-mail: {email} \r\n Phone number: {phone}");
        }
    }
}
