using System;
using System.Security.AccessControl;

namespace ConsoleApp2
{
    public class Program
    {
       static void Main(string[] args)
        {
            string uname = "junanthony25";
            char symbol = '@';

            string username = symbol + uname;

            Console.WriteLine($"Your username is {username}");
        }
    }
}