/*
Code Project 2 - Write code that validate string input 
Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
*/
using System;
namespace CodeProject2
{ 
     class code_Project2{
        public static void Main(string []args){
            string? userInput;
            string roleName = "";
            bool inputCheck = false;

            do{
                Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
                userInput = Console.ReadLine();
                if(userInput != null)
                {
                    roleName = userInput.Trim();
                    // .Trim() Removes all leading and trailing white-space characters from the current string. 
                }
                if(roleName.ToLower() == "administrator" || roleName.ToLower() == "manager"|| roleName.ToLower()== "user"){
                    inputCheck = true;
                } 
                else{
                    Console.WriteLine($"The role name you entered, \"{roleName}\", is not valid. Please try again.");
                }
            }while(!inputCheck);
            Console.WriteLine($"Your input value {roleName} has been accepted.");
        }
     }

}
