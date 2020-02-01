using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
   public  class Colecciones
    {

        public void ListaString()
        {

            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }


          Console.WriteLine(" remove");
       

            salmons.Remove("coho");

            // Iterate through the list.
            Console.WriteLine("---------------------");
            Console.WriteLine("Insertar ");

            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }

            try
            {
                salmons.Insert(1, "nuevo inserte");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error de entrada", ex.Message);

            
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("RemovEat");
            salmons.RemoveAt(2);
            imprimir(salmons);
            


        }

        private void imprimir(List<string> salmons) {


            foreach (var salmon in salmons)
            {

                Console.WriteLine(salmon);

            }


        }


    }
}
