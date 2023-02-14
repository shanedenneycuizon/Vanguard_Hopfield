using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopfield
{
    public class Hop
    {
        int[,] weight = { { 0, 0,  2, -2, -2, -2,  2, 0,  2 },
                          { 0, 0,  0,  0,  0,  0,  0, 2,  0 },
                          { 2, 0,  0, -2, -2, -2,  2, 0,  2 },
                          { 2, 0, -2,  0,  2,  2, -2, 0, -2 },
                          { 2, 0, -2,  2,  0,  2, -2, 0, -2 },
                          { 2, 0, -2,  2,  2,  0, -2, 0, -2 },
                          { 2, 0,  2, -2, -2, -2,  0, 0,  2 },
                          { 0, 2,  0,  0,  0,  0,  0, 0,  0 },
                          { 2, 0,  2, -2, -2, -2,  2, 0,  0 } };

        int[] output = new int[9];


        public Hop()
        {

        }


        public int[] TestHop(int[] input)
        {
            //int[] minus = { -1, -1, -1, 1, 1, 1, -1, -1, -1 };
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    output[row] += (input[col] * weight[row, col]);
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] < 0 || output[i] == 0)
                {
                    output[i] = -1;
                }
                else
                {
                    output[i] = 1;
                }

            }

            return output;
        }

        public void ShowArr()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.Write(output[i]);
            }
        }

    }
}
