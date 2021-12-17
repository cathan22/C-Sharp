using System;
using System.Collections;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ArrayList.
            ArrayList Lista = new ArrayList();
            Lista.Add("Crema");
            Lista.Add("Pasta Dental");
            Lista.Add("Perfume");
            Lista.Add("Peineta");
            Lista.Add("Cera");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("Lista");
            Console.WriteLine("Cntidad de elementos:{0}", Lista.Count);
            Console.WriteLine("Largo del array: {0}", Lista.Capacity);
            Console.WriteLine("Elementos:");
            ListarValores(Lista);
        }
        public static void ListarValores(IEnumerable miLista)
        {
            foreach (Object obj in miLista)
                Console.Write("{0}", obj);
            Console.WriteLine();
        }
    }
}
