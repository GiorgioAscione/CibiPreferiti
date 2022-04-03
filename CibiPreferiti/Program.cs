// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// dichiarazione del mio array //
string[] arrayCibiPreferiti = { "pasta al sugo","pizza","lasagna","risotto","antipasto","sorbetto" };

// dichiarazione lunghezza classifica //
Console.WriteLine(" La mia lista è composta da:" + arrayCibiPreferiti.Length);

// classifica in ordine intero array //

Console.WriteLine("classifica cibi: ");

for (int i = 0; i < arrayCibiPreferiti.Length; i++)
{
    Console.WriteLine(arrayCibiPreferiti[i]);
}


// cibi preferiti top - mediani e ultimi //

Console.WriteLine("cibi preferiti top, mediani e ultimi");

Console.WriteLine("Primo in classifica: " + arrayCibiPreferiti[0]);

Console.WriteLine("Ultimo in classifica: " + arrayCibiPreferiti[arrayCibiPreferiti.Length - 1]);

int posizioneMedio = arrayCibiPreferiti.Length /2;

if (arrayCibiPreferiti.Length == 0)
{
    Console.WriteLine("il mio cibo medio è  " + arrayCibiPreferiti[posizioneMedio] + arrayCibiPreferiti[posizioneMedio - 1]);
}

else
{
    Console.WriteLine("posizione media è " + arrayCibiPreferiti[posizioneMedio]);
}

    
    


 







