using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Torres_de_Hanoi
    {
        class Hanoi
        {
            
            public int movimientos { get; set; }  


        public Hanoi()
            {
                movimientos = 0; 
            }

          
            public void Mover_disco(Pila a, Pila b)
            {
         
            if (a.Top == 0)
                {
                    if (b.Top > 0)  
                    {
                        a.push(b.pop());
                   
                }
                }
                
                else if (b.Top == 0)  
            {
                    if (a.Top > 0)
                    {
                        b.push(a.pop());
                    
                }
                }
              
                else if (a.Top < b.Top)
                {
                    b.push(a.pop());
               
            }
               
                else
                {
                    a.push(b.pop());
                
            }
           
          
          
        }

           
            public int iterativo(int n, Pila ini, Pila fin, Pila aux)
            {
                
                if ((n % 2) == 0)    
                {                     
                Hanoi.MostrarEstado(ini, fin, aux);

                do
                    { 
                        Mover_disco(ini, aux); 
                        movimientos++;       
                        Hanoi.MostrarEstado(ini, fin, aux); 

                        Mover_disco(ini, fin); 
                        movimientos++;        
                    Hanoi.MostrarEstado(ini, fin, aux); 

                    if (fin.Elementos.Count < n) 
                    {
                            Mover_disco(aux, fin); 
                            movimientos++;       
                        Hanoi.MostrarEstado(ini, fin, aux); 
                    }
                    } while (fin.Elementos.Count < n); 
            }
                else  
                {
                    do
                    {
                        Mover_disco(ini, fin); 
                    movimientos++;            
                    Hanoi.MostrarEstado(ini, fin, aux); 

                    if (fin.Elementos.Count < n)  
                    {
                            Mover_disco(ini, aux); 
                        movimientos++;            
                        Hanoi.MostrarEstado(ini, fin, aux); 

                        Mover_disco(aux, fin);
                        movimientos++;       
                        Hanoi.MostrarEstado(ini, fin, aux); 
                    }
                    } while (fin.Elementos.Count < n); 
            }
                return movimientos; 
            }

           
            public int recursivo(int n, Pila ini, Pila fin, Pila aux)
            {
                if (n == 1) 
                {
                    Hanoi.MostrarEstado(ini, fin, aux); 

                Mover_disco(ini, fin);  
                movimientos++; 
                Hanoi.MostrarEstado(ini, fin, aux); 

            }
            else 
            {
                    recursivo(n - 1, ini, aux, fin); 
                    Mover_disco(ini, fin);
                    movimientos++;
                    Hanoi.MostrarEstado(ini, fin, aux);
                    recursivo(n - 1, aux, fin, ini); 
                }
                return movimientos; 
            }
        public static void MostrarEstado(Pila ini, Pila fin, Pila aux)
        {
            Console.WriteLine("INI:");
            ini.MostrarContenidoEnPila();

            Console.WriteLine("AUX:");
            aux.MostrarContenidoEnPila();

            Console.WriteLine("FIN:");
            fin.MostrarContenidoEnPila();

            Console.WriteLine(".........................");
        }
    }
    }
