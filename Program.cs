using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
                string user1 = "Shiv_p24";

            Console.WriteLine("Enter username:");
                string user2 = Console.ReadLine();
            
                string pass1 = "prasad";
            if( user1 != user2){
                Console.WriteLine("Enter Password:");
                Console.ReadLine();
                Console.WriteLine("Login Unsucessful");
            }
            
            if( user1 == user2){
            Console.WriteLine("Enter Password:");
                    string pass2 = Console.ReadLine();
                if( pass1 == pass2){
                Console.WriteLine("Login Sucessful");}
            else {
                Console.WriteLine("Login Unsucessful");
            }
           
            
        }
    }
}
}