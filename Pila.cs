using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        // Variables.
        public int Size { get; set; }    
        public int Top { get; set; }     
        public List<Disco> Elementos { get; set; } 


       
        public Pila()
        {
            Size = 0;  
            Elementos = new List<Disco>(); 
            Top = 0;
        }

      
        public Pila(int Size)
        {
            this.Size = Size;          
            Elementos = new List<Disco>(); 
            Top = -1; 

            for (int i = this.Size; i > 0; i--) 
            {
                Elementos.Add(new Disco(i));
                Top = Elementos.Last().Valor;
            }
        }

 
        public void push(Disco d)  
        {
            Elementos.Add(d);   
            Top = Elementos.Last().Valor; 
        }


        
        public Disco pop()
        {
            Disco d = Elementos.Last(); 
            Elementos.Remove(d); 

           
            try
            {
                Top = Elementos.Last().Valor;
            }
            catch (Exception)
            {
                Top = 0;
            }
            return d;
        }


        
        public bool isEmpty()
        {
            return !Elementos.Any(); 
        }

        public void MostrarContenidoEnPila()  
        {

            if (Elementos.Count == 0)
            {
                Console.WriteLine("La Pila está vacia");
            }
            else
            {
                foreach (Disco disco in Elementos)
                {
                    Console.WriteLine($"{disco.Valor}");  
                }
            }
            Console.WriteLine();
        }
    }
}
