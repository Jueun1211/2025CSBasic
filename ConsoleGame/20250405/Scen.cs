using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250405
{
    internal class Scen
    {

        public void DrawImage(string[] art, int x, int y)
        {
            for (int i = 0; i < art.Length; i++)
            {

                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(art[i]);
            }
        }
    }
}
