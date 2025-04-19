using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250405
{
    internal class Player
    {
        public string[] Player1 =
            {
                "┌--------┐",
                "│ ◑  ◑ │",
                "│   ▼   │",
                "└--------┘",
                " |      | ",
                " |      | ",

             };

        public string[] Player2 =
        {
                "┌--------┐",
                "│ ◐  ◐ │",
                "│   ▼   │",
                "└--------┘",
                " |      | ",
                " |      | ",

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
