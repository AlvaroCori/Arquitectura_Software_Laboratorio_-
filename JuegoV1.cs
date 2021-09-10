/*#1 Codigo que no se uso
  #2 Metodo grande
  #3 Identificadores excesivamente cortos
  #4 Codigo duplicado
  #5 Complejidad artificiosa
*/
using System;//#1
namespace JuegoV1
{
    public class Program
    {
        static void PrintTable(char[,] table, int row, int column, char mark)//#2
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)//#5
                {   
                    Console.Write(table[i, j] + "  ");
                }
                Console.WriteLine(" ");
            }
        }
        static char[,] CreateTable(int rows, int columns)//#2
        {
            char[,] table = new char[rows, columns];//#3
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    table[i, j] = '-';
                }
            }
            return table;
        }
        static bool limitsTable(int column, int row) {//#2
            return column <= 3 && column >= 1 && row <= 3 && row >= 1;
        }
        static bool arethreeEquals(char markLeft, char markCenter, char markRight, char mark)//#2
        {
            return markLeft == mark && markCenter == mark && markRight == mark;

        }
        static bool areThreeEqualsMarks(char[,] table,char mark)//#2
        {
            bool noWinner = true;
            noWinner = noWinner && !arethreeEquals(table[0, 0], table[0, 1], table[0, 2], mark);
            noWinner = noWinner && !arethreeEquals(table[0, 0], table[1, 0], table[2, 0], mark);
            noWinner = noWinner && !arethreeEquals(table[0, 0], table[1, 1], table[2, 2], mark);
            noWinner = noWinner && !arethreeEquals(table[0, 1], table[1, 1], table[2, 1], mark);
            noWinner = noWinner && !arethreeEquals(table[0, 2], table[1, 2], table[2, 2], mark);
            noWinner = noWinner && !arethreeEquals(table[1, 0], table[1, 1], table[1, 2], mark);
            noWinner = noWinner && !arethreeEquals(table[2, 0], table[2, 1], table[2, 2], mark);
            noWinner = noWinner && !arethreeEquals(table[2, 0], table[1, 1], table[0, 2], mark);
            return noWinner;
        }

        static void Main()//#1
        {
            char[,] table = CreateTable(3, 3);//2

            bool turn = true, noWinner = true;//#3
            char mark = 'O';//#3
            int row, column;//#3 
            while (noWinner)
            {
                if (turn)
                    Console.WriteLine("intro las coordenadas de su posicion para el jugador 1(O)(x=1-3 & y=1-3):");
                else
                    Console.WriteLine("intro las coordenadas de su posicion para el jugador 1(X)(x=1-3 & y=1-3):");
                column = Int32.Parse(Console.ReadLine());
                row = Int32.Parse(Console.ReadLine());
                if (limitsTable(row, column))//#2
                {
                    if (table[row - 1, column - 1] == '-')
                    {
                        if (turn)//#5
                            mark = 'O';
                        else
                            mark = 'X';
                        turn = !turn;
                        table[row-1, column-1] = mark; //#5
                        PrintTable(table,row , column, mark);//#2
                        noWinner = areThreeEqualsMarks(table,mark);//#2
                    }
                    else
                    {
                        Console.WriteLine("Esa casilla esta ocupada");
                    }
                }
                else
                {
                    Console.WriteLine("Esa casilla esta fuera de rango");
                }
            }
            Console.Write("termino el juego gano ");
            Console.WriteLine(mark);
            Console.ReadKey();
        }
    }
}