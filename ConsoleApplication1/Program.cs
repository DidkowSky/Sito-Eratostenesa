using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sito
    {
        private List<int> lista = new List<int>();

        //konstruktor bez wartości - domyślnie do 100 
        public Sito()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i > 1)
                {
                    lista.Add(i);
                }
            }
        }
        //konstruktor z okresloną liczbą 
        public Sito(int ile)
        {
            for (int i = 0; i <= ile; i++)
            {
                if (i > 1)
                {
                    lista.Add(i);
                }
            }
        }

        //wyświetlenie wielkości listy
        public void listaCount(){
            Console.WriteLine(lista.Count);
        }

        //wyświetlanie listy liczb
        public void listaShow()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                //Console.WriteLine(lista[i]);
                if (i % 12 == 0) Console.WriteLine();
                Console.Write(lista[i] + ", ");
            }
        }

        //usuwanie liczb z listy które nie są pierwszymi
        public void listaCalculate()
        {
            int i = 0;
            
            while( i < lista.Count)
            {
                //Console.WriteLine(" =>" + lista[i]);

                listaDeleteNum(i);
                    
                i++;
            }
        }

        //usuwanie niepotrzebnych liczb które są wielokrotnością "number"
        private void listaDeleteNum(int number)
        {
            int j = number + 1;

            while (j < lista.Count)
            {
                if (lista[j] % lista[number] == 0)
                {
                    //Console.WriteLine("Usuwam: " + lista[j]);
                    lista.RemoveAt(j);
                }
                else
                {
                    j++;
                }
            }  

        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Podaj ilość liczb:");
            n = int.Parse(Console.ReadLine());

            Sito s = new Sito(n);
            //s.listaCount();
            Console.WriteLine();
            //s.listaShow();
            s.listaCalculate();
            s.listaShow();

            Console.ReadKey();
        }
    }
}
