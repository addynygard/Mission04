using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission04
{
    internal class Receives
    {
        public static void ReceiveArray(string[] choices)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                Console.Write(choices[i]);

                if ((i +1) % 3 != 0)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.WriteLine();
                    if (i < choices.Length - 1)
                    {
                        Console.WriteLine("-----");
                    }
                }
            }
        }

        public static bool CheckWinner(string[] choices)
        {
            // Define the possible winning combinations
            int[][] winningCombinations = new int[][]
                {
            new int[] { 0, 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8 },
            new int[] { 0, 3, 6 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 0, 4, 8 },
            new int[] { 2, 4, 6 }
                };

            // Check for a winner
            foreach (var combination in winningCombinations)
            {
                if (choices[combination[0]] == choices[combination[1]] && choices[combination[1]] == choices[combination[2]])
                {
                    return true;
                }
            }

            // No winner found
            return false;
        }

        // Checks for ties
        static bool IsBoardFull(string[] choices)
        {
            foreach (var spot in choices)
            {
                if (spot != "X" && spot != "O")
                {
                    return false; 
                }
            }
            return true; 
        }
    }

    }

