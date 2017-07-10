using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_first
{
    class Program
    {
        static void Main(string[] args)
        {
            //helloworld();
            // greeting();
            // oddoreven();
            // primeornot();
            // agefactor();
            //sumofn();
            // mulofn();
            // sumorproduct();
            // multi();
            // primenum();
            //randomgame();
           // leapyear();
            //  fibbonacinumber();
           // onedime();
           //  listnames();
        }
        public static void helloworld()
        {
            Console.WriteLine("helloworld");
            Console.ReadLine();
        }
        public static void greeting()
        {

            Console.WriteLine("enter name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

        }
        public static void oddoreven()
        {
            Console.WriteLine("enter any number");
            int num;
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("entered number is even, ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("entered number is odd, ");
                Console.ReadLine();
            }

        }
        public static void primeornot()
        {
            Console.WriteLine("Enter a Number : ");
            int num1;
            num1 = int.Parse(Console.ReadLine());
            int j,i ;
            j = 0;
            for (i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    j++;
                }
            }
            if (j == 2)
            {
                Console.WriteLine("Entered Number is a Prime Number ");
            }
            else
            {
                Console.WriteLine("entered number is Not a Prime Number");
            }
            Console.ReadLine();
        }
        public static void agefactor()
        {
            Console.WriteLine("enter any number ");
            int num2;
            num2 = int.Parse(Console.ReadLine());
            if (num2<=4 && num2>=0)
            {
                Console.WriteLine("No school");

            }
            else if(num2<=10 && num2>=5)
            {
                Console.WriteLine("primary school");

            }
            else if(num2<=13 && num2>=11)
            {
                Console.WriteLine("middle school");

            }
            else if(num2<=17 && num2>=14)
            {
                Console.WriteLine("upper school");
            }
            else if(num2>=18)
            {
                Console.WriteLine("college");

            }
            else if (num2<0 || num2>100)
            {
                Console.WriteLine("age entered is invalid");
            }
            
            
        }
        public static void sumofn()
        {
            Console.WriteLine("enter Nth number ");
            int num3, i, sum = 0;
            num3 = int.Parse(Console.ReadLine());
            for(i=0;i<=num3;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum of Nth number is " + sum);
        }
        public static void mulofn() 
            {

            Console.WriteLine("enter Nth number ");
            int num3, i, sum = 0;
            num3 = int.Parse(Console.ReadLine());
            for (i = 0; i <= num3; i++)
            {
                if (i %3 == 0 || i%5 == 0 )
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of Nth number is " + sum);
        }
        public static void sumorproduct()
        {
            Console.WriteLine("enter n number ");
            int num4, i;
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter product or sum ");

            string name = (Console.ReadLine());
                if(name.Equals ("sum"))

                {
                Console.WriteLine("sum of N number " + (num4 + 1) * (num4) / 2);
               
            }
                else if(name.Equals("product")) 
                {
                int product = 1;
                for( i=1;i<=num4;i++ )
                {
                    product *= i;
                }
                Console.WriteLine("product of N number" + product);
            }
           
        }
        public static void multi()
        {
            Console.WriteLine("multipication tables ");
            int i, j;
            for (i=1;i<=12;i++)
            {
                for(j=1;j<=10;j++)
                {
                    int mul = i * j;
                    Console.WriteLine("table for a number "+i+"*"+j+"="+mul);
                }
                Console.ReadLine();
            }
                
        }
        public static void primenum()
        {
            Console.WriteLine("enter a number ");
            int n, i, j;
            int prime;
            n = int.Parse(Console.ReadLine());
            for(i=2;i<=n;i++)
            {
                prime = 0;
                for(j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        prime = 1;
                        break;
                    }
                }
                if(prime==0 && n!=1)
                {
                    Console.WriteLine("prime numbers are"+i);
                }
            }
        }
        public static void randomgame()
        {
            Random random = new Random();

            int returnValue = random.Next(1, 100);
            int Guess;
            int temp = 0;

            Console.WriteLine("pick a number between 1-100 ");

            while (true)
            {
                Guess = int.Parse(Console.ReadLine());

                if (Guess < returnValue)
                {
                    Console.WriteLine("you have to pick bigger value than " + Guess );
                  
                }
                else if (Guess > returnValue)
                {
                    Console.WriteLine("you have to pick lower value than " + Guess );
                   

                }
                else if (Guess == returnValue)
                {
                    Console.WriteLine("Well done!! you got the number " + returnValue);
                    
                }

                temp++;
                if(temp == 6)
                {
                    break;
                }

            }
            Console.ReadLine();

        }
        public static void leapyear()
        {
            int year;
            for(year=2016;year<=2100;year= year + 4)
            {
                Console.WriteLine("coming leapyears are " + year);
            }

            Console.ReadLine();
        }
        public static void fibbonacinumber()
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the number ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();

        }
        public static void onedime()
        {
            string[] names =  { "jaya", "kranthi", "sasi", "rohith", "vishnu", "pavan" };
            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine("array of names are " + names[i]);
            }

        }
        public static void listnames()
        {
            List<string> names = new List<string>();
            names.Add("jaya");
            names.Add("kranthi");
            names.Add("sasi");
            for(var i=0;i<names.Count;i++)
            {
                Console.WriteLine("list string names are " + names[i]);
            }
        }



    }
}

