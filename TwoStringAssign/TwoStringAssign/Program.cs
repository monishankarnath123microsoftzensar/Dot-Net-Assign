using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStringAssign
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            Console.WriteLine("String Menu");
            Console.WriteLine("1.Concatenate String");
            Console.WriteLine("2.Length of 2 String");
            Console.WriteLine("3.SubString");
            Console.WriteLine("4.Replace");
            Console.WriteLine("5.Uppercase");
            Console.WriteLine("6.Lowercase");
            Console.WriteLine("7.Trim");
            Console.WriteLine("8.Split");
            Console.WriteLine("Choose a Number or Enter 9 to exit: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            switch(num)
            {
                case 1:
                    //var concat = str1 + " " + str2;
                    Console.WriteLine(str1 + " " + str2);
                    break;
                case 2:
                    int sum = str1.Length + str2.Length;
                    Console.WriteLine("Length: "+sum);
                    break;
                case 3:
                    Console.WriteLine("From which index num you want to retrieve the substring of both string: ");
                    int sub = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("String1: "+str1.Substring(sub));
                    Console.WriteLine("String2: " + str2.Substring(sub));
                    break;
                case 4:
                    var concat = str1 + " " + str2;
                    Console.WriteLine("Original \n"+ concat);
                    Console.WriteLine("Enter a word you want to replace: ");
                    string rep1 = Console.ReadLine();
                    Console.WriteLine("With: ");
                    string rep2 = Console.ReadLine();
                    Console.WriteLine("After Replace: \n"+ str1.Replace(rep1, rep2)+" "+ str2.Replace(rep1, rep2));
                    break;
                case 5:
                    Console.WriteLine("Strig 1: "+str1.ToUpper());
                    Console.WriteLine("Strig 2: " + str2.ToUpper());
                    break;
                case 6:
                    Console.WriteLine("Strig 1: " + str1.ToLower());
                    Console.WriteLine("Strig 2: " + str2.ToLower());
                    break;
                case 7:
                    Console.WriteLine("Strig 1: " + str1.Trim());
                    Console.WriteLine("Strig 2: " + str2.Trim());
                    break;
                case 8:
                    var concat1 = str1 + " " + str2;
                    Console.WriteLine("Original \n" + concat1);
                    char[] spearator = { ' ', ' ' };
                    int count = 4;
                    string[] strlist = concat1.Split(spearator,
                           count, StringSplitOptions.None);
                    Console.WriteLine("After split from space");
                    foreach (String s in strlist)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            Console.Read();
        }
    }
}
