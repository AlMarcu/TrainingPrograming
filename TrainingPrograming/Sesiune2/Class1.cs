using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Sesiune2
{
    internal class Cursant
    {
        string numeCursant;
        string prenumeCursant;
        int varsta;
        int cnp;
        bool esteActiv;
        char gen;
        float nota;
        double inaltime;

        [Test]
        public void metodatest()
        {
            numeCursant = "Nemes";
            prenumeCursant = "Sorin";
            varsta = 47;
            //cnp = 1770202268232;
            var numarLung = 1770202268232;
            esteActiv = false;
            gen = 'M';
            nota = 9.12f;
            inaltime = 1.85;

            Console.Write("Nume cursant: " + numeCursant + " " + prenumeCursant + "\n");
            //Console.WriteLine(" " + prenumeCursant);
            Console.WriteLine("Varsta: " + varsta);
            Console.WriteLine("CNP: " + numarLung);
            Console.Write("Activ: " + esteActiv + " ");
            Console.Write("Nota: " + nota);
                       

        }
    }
        }

