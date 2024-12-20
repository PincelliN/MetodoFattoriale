﻿// See https://aka.ms/new-console-template for more information

// chiedo al utente di inserire un parametro
Console.Write("Inserisci un numero : ");

//leggi e  converti in intero  ciò che inserisce l'utente
int x = Convert.ToInt32(Console.ReadLine());

//scrivi il fattoriale 
Console.WriteLine($"il fattoriale di {x} è : {factorial(x)}");


static int factorial(int x)
{
    //caso base per uscire dalla ricorsiva
    if (x == 0)
    {
        //con x = 0 otteniamo uno e usciamo dal metodo
        return 1;
    }
    //qui il metodo factorial  richiama se stesso fino a quando il parametro passato non e 0
    //se x parte con il valore di 5  il metodo factorial retituira 5*4*3*2*1*1;
    return x * factorial(--x);

}