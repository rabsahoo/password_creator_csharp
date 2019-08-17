using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_creator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int passwordLength = 10;
            var random = new Random();
            var buffer = new char[passwordLength];

            for(var i =0; i<passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
        
           
            var num = new Random();
          
            var numpassword = "";

            for (var i = 0; i <4; i++)
            {
                numpassword = numpassword + (int)(random.Next(1, 10));
            }


             var completepassword = password + "@" + numpassword;

           Console.WriteLine(completepassword);
                
            Console.WriteLine();
        }
    }
}
