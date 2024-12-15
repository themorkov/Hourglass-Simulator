using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sandclock
{
    internal class Hourglass
    {
        private char[][] hourglass;
        public int firstglassval;
        public int secondglassval;
        int firstglassbalance = 0;
        int secondglassbalance = 0;
        public int requiredtime;


        public Hourglass()
        {
            hourglass = new char[14][];
            hourglass[0] = new char[31] { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', ' ', ' ', ' ', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
            hourglass[1] = new char[31] { ' ', '\\', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '/', ' ', ' ', ' ', ' ', ' ', '\\', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '/', ' ' };
            hourglass[2] = new char[31] { ' ', ' ', '\\', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\\', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '/', ' ', ' ' };
            hourglass[3] = new char[31] { ' ', ' ', ' ', '\\', 'o', 'o', 'o', 'o', 'o', 'o', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\\', 'o', 'o', 'o', 'o', 'o', 'o', '/', ' ', ' ', ' ' };
            hourglass[4] = new char[31] { ' ', ' ', ' ', ' ', '\\', 'o', 'o', 'o', 'o', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\\', 'o', 'o', 'o', 'o', '/', ' ', ' ', ' ', ' ' };
            hourglass[5] = new char[31] { ' ', ' ', ' ', ' ', ' ', '\\', 'o', 'o', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\\', 'o', 'o', '/', ' ', ' ', ' ', ' ', ' ' };
            hourglass[6] = new char[31] { ' ', ' ', ' ', ' ', ' ', ' ', '\\', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\\', '/', ' ', ' ', ' ', ' ', ' ', ' ' };
            hourglass[7] = new char[31] { ' ', ' ', ' ', ' ', ' ', ' ', '/', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '/', '\\', ' ', ' ', ' ', ' ', ' ', ' ' };
            hourglass[8] = new char[31] { ' ', ' ', ' ', ' ', ' ', '/', 'o', 'o', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '/', 'o', 'o', '\\', ' ', ' ', ' ', ' ', ' ' };
            hourglass[9] = new char[31] { ' ', ' ', ' ', ' ', '/', 'o', 'o', 'o', 'o', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '/', 'o', 'o', 'o', 'o', '\\', ' ', ' ', ' ', ' ' };
            hourglass[10] = new char[31] { ' ', ' ', ' ', '/', 'o', 'o', 'o', 'o', 'o', 'o', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '/', 'o', 'o', 'o', 'o', 'o', 'o', '\\', ' ', ' ', ' ' };
            hourglass[11] = new char[31] { ' ', ' ', '/', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '/', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '\\', ' ', ' ' };
            hourglass[12] = new char[31] { ' ', '/', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '\\', ' ', ' ', ' ', ' ', ' ', '/', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', '\\', ' ' };
            hourglass[13] = new char[31] { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', ' ', ' ', ' ', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        }

        public void printarr()

        {
            for (int i = 0; i < hourglass.Length; i++)
            {
                for (int j = 0; j < hourglass[i].Length; j++)
                {
                    Console.Write(hourglass[i][j]);
                }
                Console.WriteLine("\t");
            }
        }
        internal void putvalue(char[][] arr, int value, int index1, int index2)
        {
            if (value < 10)
            {
                arr[index1][index2] = Convert.ToChar(value.ToString());
                arr[index1][index2+1] = '-';

            }
            else
            {
                arr[index1][index2] = Convert.ToChar((value / 10).ToString());
                arr[index1][index2 + 1] = Convert.ToChar((value % 10).ToString());
            }
        }
        internal void putvalue(char[][] arr, char value, int index1, int index2)
        {
            arr[index1][index2] = value;
        }

        public void putinarr()
        {
            putvalue(hourglass, firstglassbalance, 0, 6);
            putvalue(hourglass, secondglassbalance, 0, 23);
            putvalue(hourglass, firstglassval, 13, 6);
            putvalue(hourglass, secondglassval, 13, 23);
        }

        public void run()
        {
            flip();

        }
        internal void flip()
        {
            Console.WriteLine("Choose an action");
            ConsoleKeyInfo key = Console.ReadKey();
            if(key.Key == ConsoleKey.Q)
            {
                putvalue(hourglass, firstglassval, 0, 6);
                putvalue(hourglass, firstglassbalance, 13, 6);
            }
            if(key.Key == ConsoleKey.E)
            {
                putvalue(hourglass, secondglassval, 0, 23);
                putvalue(hourglass, secondglassbalance, 13, 23);
            }
            if (key.Key == ConsoleKey.W)
            {
                putvalue(hourglass, firstglassval, 0, 6);
                putvalue(hourglass, firstglassbalance, 13, 6);
                putvalue(hourglass, secondglassval, 0, 23);
                putvalue(hourglass, secondglassbalance, 13, 23);
            }
            else
            {
                putvalue(hourglass, 'E', 6, 12); 
                putvalue(hourglass, 'R', 6, 13);
                putvalue(hourglass, 'R', 6, 14);
                putvalue(hourglass, 'O', 6, 15);
                putvalue(hourglass, 'R', 6, 16);
            }
            Console.Clear();
            printarr();
            
            

        }
    }


}
