using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandclock
{
    internal class Valuetable
    {
        private char[][] tablearr;

        public Valuetable()
        {
            tablearr = new char[3][];
            tablearr[0] = new char[18] { '|', '-', '-', '-', '-', '|', '|', '-', '-', '-', '-', '|', '|', '-', '-', '-', '-', '|' };
            tablearr[1] = new char[18] { '|', '-', '-', '-', '-', '|', '|', '-', '-', '-', '-', '|', '|', '-', '-', '-', '-', '|' };
            tablearr[2] = new char[18] { '|', '-', '-', '-', '-', '|', '|', '-', '-', '-', '-', '|', '|', '-', '-', '-', '-', '|' };
        }

        public void printarr()

        {
            for (int i = 0; i < tablearr.Length; i++)
            {
                for (int j = 0; j < tablearr[i].Length; j++)
                {
                    Console.Write(tablearr[i][j]);
                }
                Console.WriteLine("\t");
            }
        }

        public void putinarr(int value, int index)
        {
            if (value < 10)
            {
                tablearr[1][index] = Convert.ToChar(value.ToString());
            }
            else
            {
                int value1 = value / 10;
                tablearr[1][index] = Convert.ToChar(value1.ToString());
                int value2 = value % 10;
                tablearr[1][index + 1] = Convert.ToChar(value2.ToString());
            }
        }

        public char[][] TableArr
        {
            get { return tablearr; }
            set { tablearr = value; }
        }

    }
}
