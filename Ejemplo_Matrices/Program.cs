using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {3,1,2,4 }; //Matriz 1D
            int[,] b = new int[,] { { 3,1,5}, {7,2,7 } };//Matriz 2D
            int[][] c = new int[][]
            {
                new int[]{2,1,0},
                new int[]{-3},
                new int[]{1,2}
            }; //Matriz escalonada
            int[,,] d = new int[,,] 
            { 
                { 
                    { 2 , 4 }, 
                    { 1 , 3 } 
                }, 
                { 
                    { 2 , 1 },
                    { 7 , 5 } 
                } 
            };//Matriz 3D

            int[][][] e = new int[3][][]
            {
                new int [][]
                {
                    new int[]{1,2 },
                    new int[]{3,4 } 
                },
                new int [][]
                {
                    new int[]{0,1},
                    new int[]{2}
                },
                new int [][]{
                    new int[] {0,1,2,3}
                }
            }; //Matriz escalonada


            

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
