//ejercicio2 melvin perez ramirez
using System.Linq;

// Fuente de datos
int[] scores = { 90, 71, 82, 93, 75, 82 };

// Filtro: score > 80
var query = from score in scores
            where score > 80
            orderby score descending
            select score;

// ordenados de manera descendente
foreach (var result in query)
{
    Console.WriteLine(result);
}