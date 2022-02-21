﻿using System;
using System.Drawing;
using System.Threading.Tasks;
    
class Ahorcado
{
    static void Main(string[] args)
    {
        //llamar a las otras clases
        Logic logic = new Logic();
    }
    class Logic 
    {
      List<string> wort_input = new List<string>(); //lista para guardas las palabras
      string[] palabras_array = new string[]{}; //array que tendra las palabras
      string palabra; //entrada de la palabra
      char[] palabra_adivinar; //la palabra escogida en tipo char
      
      public Logic()
      {
        Console.WriteLine("Geben Sie bitte Worte ab, damit das Spiel anfagen kann");
        while (true)
        {
          Console.Write("Wort: ");
          palabra = Console.ReadLine();
          if (palabra == "q"){break;} //Si es q salir
          else{wort_input.Add(palabra);} //de lo contrario entrar en la list
        }
        
        palabras_array = wort_input.ToArray(); //se convierte la lista en un array
        string choosed_wort = palabras_array[random_num_generation()]; //Se guarda la palabra aleatoria en una variable para convertirla en char
        palabra_adivinar = choosed_wort.ToCharArray(); //se convierte la palabra en un array tipo char
        char[] lista_vacia = new char[palabra_adivinar.Length]; //lista que se imprimira vacia y se llenara

        for (int i = 0; i < palabra_adivinar.Length;i++)
        {
          lista_vacia[i] = '_';
        }
        foreach (char i in lista_vacia)
        {
          
          Console.Write(i+" ");

        }

      }
      private void getArray()
      {
        Console.WriteLine(String.Join("\n", palabras_array));
      }
      private int random_num_generation()
      {
        Random random = new Random();
        int i = random.Next(palabras_array.Length);
        return i;
      }
    }
}
  