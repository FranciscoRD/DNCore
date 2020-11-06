using System;
using Cap08.Arreglos;//             8.4
using Cap08.Excepciones;//          8.5
using Cap08.CardShuffling;//        8.6
using Cap08.PassElems;//            8.7
using Cap08.GradeBook;//            8.8
using Cap08.MdArrays;//             8.9
using Cap08.GBRectangularArray;//   8.10
using Cap08.VariableArgs;//         8.11
using Cap08.Referencias;//          8.13

namespace Cap08
{
    class Program
    {
        #region 8.12 Argumentos de la linea de comandos
        // Para enviar parametros en DotNetCore solo se necesita ejecutar
        // dotnet run param1 param2 param3 desde el directorio del proyecto
        /*
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine(
                    "Error: Please re-enter the entire command, inluding\n"+
                    "an array size, initial value and increment.");
            }
            else
            {
                var arrayLength = int.Parse(args[0]);
                var array = new int[arrayLength];

                var initialValue = int.Parse(args[1]);
                var increment = int.Parse(args[2]);

                for (int counter = 0; counter < array.Length; counter++)
                {
                    array[counter] = initialValue + increment * counter;
                }
                Console.WriteLine($"{"Index"}{"Value",8}");
                for (int counter = 0; counter < array.Length; counter++)
                {
                    Console.WriteLine($"{counter,5}{array[counter],8}");
                }
            }
        }
         */
        #endregion
        static void Main(string[] args)
        {
            #region 8.13 Passing Arrays by Value and by Reference
            ArrayReferenceTest.Principal();
            #endregion
            #region 8.11 Variable-Length Argument Lists
            // ParamArrayTest.Principal();
            #endregion

            #region 8.10 GradeBook with MD Arrays
            // GBRectangularArray.GradeBookTest.Principal();
            #endregion

            #region 8.9 Multidimensional Arrays
            // MdArrays.InitArray.Principal();
            #endregion

            #region 8.8 GradeBook Exercise
            // GradeBookTest.Principal();
            #endregion

            #region 8.7 Passing Arrays
            // PassArray.Principal();
            #endregion

            #region 8.6 Card Shuffling 
            // DeckOfCardTest.Principal(); 
            #endregion

            #region 8.5 Exceptions
            // StudentPoll.First();
            // StudentPoll.Second();
            #endregion

            #region 8.4 Arrays - Vars
            // RollDie.Principal();
            // BarChart.Principal();
            // ForEachTest.Principal();
            // SumArray.Principal();
            // InitArray.Third();
            // InitArray.Second();
            // InitArray.First();
            #endregion
        }
    }
}
