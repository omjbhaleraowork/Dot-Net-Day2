﻿using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            // o.i = 100;
           // o.set1(10);
           // Console.WriteLine(o.Get1());
           o.P1 = 10;
            Console.WriteLine(o.P1);
            o.Name= "pankaj";
            Console.WriteLine(o.Name);
        }
    }


    public class Class1 
    {
        /*private int i;
        public void set1(int value)
        {
            if (value < 100)
            {
                i = value;
            }
            else
            {
                Console.WriteLine("invalid i");
            }
            public int Get1()
            {
                return i;
            }*/

        private int p1;//variable

        public int P1//property
        {
            set
            {
                if (value < 100)
                {
                    p1 = value;
                }
                else
                {
                    Console.WriteLine("invalid p1");
                }
            }
            get
            {
                    return p1;
            }
            
        }

        private String name;
        public String Name
        {
            set
            {
                name = value;
            }
            get 
            {
                return name;
            }    
        }


    }
    }
