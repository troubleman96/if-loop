using System;

class Program{

    static void Main(string [] arg){

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if(age >= 18 && age <= 25){
            Console.WriteLine("Your age is between 18 and 25");
        }
        else if(age >= 26 || age <= 50){
            Console.WriteLine("26 or 50");
        }

    }
}
