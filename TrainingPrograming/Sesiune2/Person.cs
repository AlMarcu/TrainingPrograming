using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingPrograming.Sesiune2
{
    internal class Person
    {
        string nume;
        string prenume;
        string gen;
        int age;
        int x;


        [Test]
        public void MetodaCalcul()
        {
            age = 47;
            x = 20;
            int calculateAge = age + x;
            Console.WriteLine("You will be " + calculateAge + " years old in 15 years!");
        }

        [Test]
        public void MetodaDisplay()
        {
            nume = "Marcu";
            prenume = "Alexandrina";
            gen = "Female";
            age = 47;
            int calculateAge = age + 15;
            Console.WriteLine("The person's details are as follows:");
            Console.WriteLine("- First Name: " + prenume);
            Console.WriteLine("- Last Name: " + nume);
            Console.WriteLine("- Gender: " + gen);
            Console.WriteLine("You will be " + calculateAge + " years old in 15 years!");
        }
        [Test]
        public void AgeGender()
        {
            IsOld(65);
            ShowGender("");
        }

        public void IsOld(int age)
        {
            if (age >= 100)
            {
                Console.WriteLine("You are ancient!");
            }
            else if (age >= 50)
            {
                Console.WriteLine("You are old!");
            }
            else if (age < 50)
            {
                Console.WriteLine("You are still young!");
            }
        }
         
        public void ShowGender(string gen)
            {
            switch (gen)
            {
                case "Male":
                    Console.WriteLine("You are a male!");
                    break;

                case "Female":
                    Console.WriteLine("You are a female!");
                    break;

                default:
                Console.WriteLine("You haven't specified your gender!");
                    break;

            }
        }
    }
 }




    

