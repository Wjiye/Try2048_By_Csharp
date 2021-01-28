using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveNum
{
    public class LeftMove
    {
        public static int[,] TheLeftAll(int[,] arr)
        {
            int[] line = new int[4];
            for (int l = 0; l <= 3; l++)
            {
                for (int c = 0; c <= 3; c++)
                {
                    line[c] = arr[l, c];
                }
                line = TheLeft(line);
                for (int i = 0; i <= 3; i++)
                {
                    arr[l, i] = line[i];
                }
            }
            return arr;
        }
        private static int[] TheLeft(int[] arr)
        {
            for (int range = 0; range <= 6; range++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (arr[i] == 0 && i != 3 && arr[i + 1] > 0)
                    {
                        arr[i] = arr[i + 1];
                        arr[i + 1] = 0;
                    }
                }
            }
            return arr;
        }
        public static int[,] LeftAdd(int[,] arr)
        {
            for (int l = 0; l <= 3; l++)
            {
                for (int c = 0; c <= 3; c++)
                {
                    if (arr[l, c] > 0 && c != 3 && arr[l, c + 1] == arr[l, c])
                    {
                        arr[l, c] = arr[l, c + 1] * 2;
                        arr[l, c + 1] = 0;
                    }
                }
            }
            return arr;
        }
    }
    public class RightMove {
        private static int[] TheRight(int[] arr)
        {
            for (int range = 0; range <= 6; range++)
            {

                for (int i = 3; i >= 0; i--)
                {
                    if (arr[i] == 0 && i != 0 && arr[i - 1] > 0)
                    {
                        arr[i] = arr[i - 1];
                        arr[i - 1] = 0;
                    }
                }
            }
            return arr;
        }
        public static int[,] TheRightAll(int[,]arr) {
            int[] line = new int[4];
            for (int l = 0; l <= 3; l++)
            {
                for (int c = 0; c <= 3; c++)
                {
                    line[c] = arr[l, c];
                }
                line = TheRight(line);
                for (int i = 0; i <= 3; i++)
                {
                    arr[l, i] = line[i];

                }
            }
            return arr;
        }
        public static int[,] RightAdd(int[,] arr) {
            for (int l = 0; l <= 3; l++)
            {
                for (int c = 2; c >= 0; c--)
                {
                    if (c != 3 && arr[l, c + 1] > 0 && arr[l, c + 1] == arr[l, c])
                    {
                        arr[l, c + 1] = arr[l, c] * 2;
                        arr[l, c] = 0;
                    }
                }
            }
            return arr;

        }
    }
    public class UpMove {
        private static int[] TheUp(int[] arr) {

            for (int range = 0; range <= 6; range++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (arr[i] == 0 && i != 3 && arr[i + 1] > 0)
                    {
                        arr[i] = arr[i + 1];
                        arr[i + 1] = 0;
                    }
                }
            }
            return arr;
        }
        public static int[,] TheUpAll(int[,] arr) {
            int[] column = new int[4];
            for (int c = 0; c <= 3; c++)
            {
                for (int l = 0; l <= 3; l++)
                {
                    column[l] = arr[l, c];
                }
                column = TheUp(column);
                for (int i = 0; i <= 3; i++) {
                    arr[i, c] = column[i];
                }
            }
            return arr;
        }
        public static int[,] UpAdd(int[,] arr) {
            for (int c = 0; c <= 3; c++)
            {
                for (int l = 0; l <= 3; l++)
                {
                    if (arr[l, c] > 0 && l != 3 && arr[l + 1, c] == arr[l, c]) {
                        arr[l, c] = arr[l + 1, c] * 2;
                        arr[l + 1, c] = 0;
                    }
                }
            }
            return arr;
        }
    }
    public class DownMove {
        private static int[] TheDown(int[] arr) {
            for (int range = 0; range <= 6; range++)
            {

                for (int i = 3; i >= 0; i--)
                {
                    if (arr[i] == 0 && i != 0 && arr[i - 1] > 0)
                    {
                        arr[i] = arr[i - 1];
                        arr[i - 1] = 0;
                    }
                }
            }
            return arr;
        }
        public static int[,] TheDownAll(int[,] arr) {
            int[] column = new int[4];
            for (int c = 0; c <= 3; c++) {
                for (int l = 0; l <= 3; l++)
                {
                    column[l] = arr[l, c];
                }
                column = TheDown(column);
                for (int i = 0; i <= 3; i++) {
                    arr[i, c] = column[i];
                }
            }
            return arr;
        }
        public static int[,] DownAdd(int[,] arr) {
            for (int c = 0; c <= 3; c++)
            {
                for (int l = 2; l >= 0; l--)
                {
                    if (l != 3 && arr[l+1, c] > 0 && arr[l+1, c] == arr[l, c])
                    {
                        arr[l+1, c] = arr[l, c] * 2;
                        arr[l, c] = 0;
                    }
                }
            }
            return arr;
        }
    }
}
