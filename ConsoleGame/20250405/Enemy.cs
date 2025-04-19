using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250405
{
    internal class Enemy
    {
        public string[] Monster =
             {
                "  (X ＠X)  ",
                "  |  ▒  |  ",
                " /| --- |\\ ",
                "/ |     | \\",
                "* |-----| *",
                "   |  |   ",
            };

        public string[] REMOVE =
        {
            "                                   ",
            "                                   ",
            "                                   ",
            "                                   ",
            "                                   ",
            "                                   ",
            "                                   ",
        };

        public void RemoveImage(string[] art)
        {
            for (int i = 0; i < REMOVE.Length; i++)
            {
                Console.WriteLine(REMOVE[i]);
            }
        }
    }
}
