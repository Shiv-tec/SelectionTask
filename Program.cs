using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number:");
                
                string word_4;

            word_4 = Console.ReadLine();

                int num_1;
            num_1 = int.Parse(word_4);
            
            Console.WriteLine("Insert another number:");

                string word_5;

            word_5 = Console.ReadLine();

                int num_2;
            num_2 = int.Parse(word_5);
            
                int sum;
            sum = num_2 + num_1;

            if(sum > 10){
                Console.WriteLine("Sum of numbers is greater than 10");
            } else{
            if(sum < 10) {
                Console.WriteLine("Sum of numbers is smaller than 10");
            }
            else{ 
                Console.WriteLine("Sum of numbers is equal to 10");
            }
            }
            // task 3 ^^

            //task 1 & 2 below
            
            
        //     Console.WriteLine("State your age:");

        //         string age = Console.ReadLine();

        //         int ageNum = int.Parse(age);

        //     if(ageNum > 17){
               
        //         Console.WriteLine("State your gender (M or F):");
        //             string gender = Console.ReadLine();

        //         Console.WriteLine(gender + " " + "is an adult");

        //     } else {
            
        //         Console.WriteLine("State your gender (M or F):");
        //             string gender = Console.ReadLine();

        //         Console.WriteLine(gender + " " + "is not an adult");
        //     }
         }
    }
}
