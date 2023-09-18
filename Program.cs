using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login l1 = new Login();
            l1.setNameLogin("sidharth");
            Console.WriteLine(l1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        public String name;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }
    class Login : User
    {
        public void setNameLogin(String name)
        {
            this.name = name;
        }
    }
}
