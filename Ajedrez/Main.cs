using System;
using System.Collections.Generic;
using clasePiezas;
using System.Threading.Tasks;

namespace Ajedrez_main
{
    class Ajedrez
    {
        
       static void Main(string[] arg)
       {
            Logic logic = new Logic();
            logic.start();
       }
        
       class Logic
       {
        Piezas piezas = new Piezas();
           
            string[,] tablero = new string[8, 8];
            public Logic()
            {
                rellenoTableroFichas();                               
            }
            public void start()
            {
                
                while(true)
                {
                        boardImpress();
                        Thread.Sleep(2000);
                }
            }
            private void boardImpress()
            {
                    Console.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (i % 2 == 0 && j % 2 == 0|| i % 2 != 0 && j % 2 != 0)
                            {
                                if(tablero[i,j] == "   ")
                                {                           
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }
                                else if(piezas.soyBlanca(i,j) && !piezas.soyNegra(i,j))
                                { 
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }
                                else if(piezas.soyNegra(i,j) && !piezas.soyBlanca(i,j))
                                {                            
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }
                                
                                
                                
                            }    
                            else
                            {
                                    if(tablero[i,j] == "   ")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Cyan;
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write(tablero[i,j]);
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                    }
                                    else if(piezas.soyNegra(i,j) && ! piezas.soyBlanca(i,j))
                                    {
                                        Console.BackgroundColor = ConsoleColor.Cyan;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.Write(tablero[i,j]);
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                
                                    }
                                    else if(piezas.soyBlanca(i,j) && !piezas.soyNegra(i,j))
                                    {
                                        Console.BackgroundColor = ConsoleColor.Cyan;
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write(tablero[i,j]);
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                    }
                                    
                            }
                                
                            
                        }
                        Console.WriteLine();
                    }
            }
            void rellenoTableroFichas()
            {
                tablero[0,1] = " 0 ";
                //relleno el tablero vacio
                for(int i = 0; i<8; i++)
                {
                    for(int j = 0; j<8; j++)
                    {   
                        tablero[i,j] = "   ";
                    }
                }
                //Fichas negras
                tablero[piezas.getCoordinat_piezas_negras("TorreIi"),piezas.getCoordinat_piezas_negras("TorreIj")] = piezas.getPiezas("Torre");
                tablero[piezas.getCoordinat_piezas_negras("ArfilBi"),piezas.getCoordinat_piezas_negras("ArfilBj")] = piezas.getPiezas("Arfil");
                tablero[piezas.getCoordinat_piezas_negras("Caballo1i"),piezas.getCoordinat_piezas_negras("Caballo1j")] = piezas.getPiezas("Caballo");
                tablero[piezas.getCoordinat_piezas_negras("Reyi"),piezas.getCoordinat_piezas_negras("Reyj")] = piezas.getPiezas("Rey");
                tablero[piezas.getCoordinat_piezas_negras("Reinai"),piezas.getCoordinat_piezas_negras("Reinaj")] = piezas.getPiezas("Reina");
                tablero[piezas.getCoordinat_piezas_negras("Caballo2i"),piezas.getCoordinat_piezas_negras("Caballo2j")] = piezas.getPiezas("Caballo");
                tablero[piezas.getCoordinat_piezas_negras("ArfilNi"),piezas.getCoordinat_piezas_negras("ArfilNj")] = piezas.getPiezas("Arfil");
                tablero[piezas.getCoordinat_piezas_negras("TorreDi"),piezas.getCoordinat_piezas_negras("TorreDj")] = piezas.getPiezas("Torre");
                //Peon
                tablero[piezas.getCoordinat_piezas_negras("Peon1i"),piezas.getCoordinat_piezas_negras("Peon1j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_negras("Peon2i"),piezas.getCoordinat_piezas_negras("Peon2j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_negras("Peon3i"),piezas.getCoordinat_piezas_negras("Peon3j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_negras("Peon4i"),piezas.getCoordinat_piezas_negras("Peon4j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_negras("Peon5i"),piezas.getCoordinat_piezas_negras("Peon5j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_negras("Peon6i"),piezas.getCoordinat_piezas_negras("Peon6j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_negras("Peon7i"),piezas.getCoordinat_piezas_negras("Peon7j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_negras("Peon8i"),piezas.getCoordinat_piezas_negras("Peon8j")] = piezas.getPiezas("Peon");
                //Peon

                //Fichas Negras
                tablero[piezas.getCoordinat_piezas_blancas("TorreIi"),piezas.getCoordinat_piezas_blancas("TorreIj")] = piezas.getPiezas("Torre");
                tablero[piezas.getCoordinat_piezas_blancas("ArfilBi"),piezas.getCoordinat_piezas_blancas("ArfilBj")] = piezas.getPiezas("Arfil");
                tablero[piezas.getCoordinat_piezas_blancas("Caballo1i"),piezas.getCoordinat_piezas_blancas("Caballo1j")] = piezas.getPiezas("Caballo");
                tablero[piezas.getCoordinat_piezas_blancas("Reyi"),piezas.getCoordinat_piezas_blancas("Reyj")] = piezas.getPiezas("Rey");
                tablero[piezas.getCoordinat_piezas_blancas("Reinai"),piezas.getCoordinat_piezas_blancas("Reinaj")] = piezas.getPiezas("Reina");
                tablero[piezas.getCoordinat_piezas_blancas("Caballo2i"),piezas.getCoordinat_piezas_blancas("Caballo2j")] = piezas.getPiezas("Caballo");
                tablero[piezas.getCoordinat_piezas_blancas("ArfilNi"),piezas.getCoordinat_piezas_blancas("ArfilNj")] = piezas.getPiezas("Arfil");
                tablero[piezas.getCoordinat_piezas_blancas("TorreDi"),piezas.getCoordinat_piezas_blancas("TorreDj")] = piezas.getPiezas("Torre");
                //Peon
                tablero[piezas.getCoordinat_piezas_blancas("Peon1i"),piezas.getCoordinat_piezas_blancas("Peon1j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_blancas("Peon2i"),piezas.getCoordinat_piezas_blancas("Peon2j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_blancas("Peon3i"),piezas.getCoordinat_piezas_blancas("Peon3j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_blancas("Peon4i"),piezas.getCoordinat_piezas_blancas("Peon4j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_blancas("Peon5i"),piezas.getCoordinat_piezas_blancas("Peon5j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_blancas("Peon6i"),piezas.getCoordinat_piezas_blancas("Peon6j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_blancas("Peon7i"),piezas.getCoordinat_piezas_blancas("Peon7j")] = piezas.getPiezas("Peon");
                tablero[piezas.getCoordinat_piezas_blancas("Peon8i"),piezas.getCoordinat_piezas_blancas("Peon8j")] = piezas.getPiezas("Peon");
                //Peon
            }
          
       }
    }
}

        
