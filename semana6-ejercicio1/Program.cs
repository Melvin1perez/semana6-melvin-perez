//ejercicio1 melvin perez ramirez
using System.Linq;

int[] scores = { 97, 92, 81, 60 };

//score > 80 //filtros
var query = from score in scores
            where score > 80
            select score;

foreach (var result in query)
{
    Console.WriteLine(result);
}