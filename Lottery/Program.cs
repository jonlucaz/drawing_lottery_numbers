using System;
using System.Linq;

int[] vetor = new int[6];
Random random = new Random();
int aleatorio;

for (int c = 0; c < 6; c++)
{
    aleatorio = random.Next(1, 61);
    vetor[c] = aleatorio;



    while (vetor.Contains(aleatorio))
    {
        aleatorio = random.Next(1, 61);
    }


}

Array.Sort(vetor);

foreach (int i in vetor)
{
    
    Console.Write(i + " ");
}


