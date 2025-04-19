namespace _20250419
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 총 만들기

            // 총에 파격할 몬스터 하나 만들기

            // 총을 든 캐릭터 이미지를 그려줘

            string[] RigtBlash =
            {
                "~●"
            };

            string[] LeftBlash =
            {
                "●~"
            };

            //오른쪽 방향으로 총을 가르키고 있는 캐릭터를 만들어줘
            // 왼쪽 방향을 바라보고 있는 캐릭터를 아스키 아트 C# string[] 타입으로 만들어줘
            string[] player =
            {
    "      ╭────╮",
    "     ( ⚆_⚆ )",
    "     /︶︶︶\\ ",
    "    /│       ⊃︻デ═一",
    "   ╱╱╱│     ╭┴╮",
    "  ╱╱╱╱╰─╯  ╰─╯"
};

            string[] enemy =
                {

    "      ╭────╮",
    "     ( ⚆_⚆ )",
    "      /︶︶︶\\",
    "<══━⊂        │\\",
    "     ╭┴╮     │╲╲╲",
    "    ╰─╯ ╰─╯╲╲╲╲"
            };


            Scen scene = new Scen();

            scene.DrawImage(player, 0, 0);
            scene.DrawImage(enemy, 50, 0);
            scene.DrawImage(RigtBlash, 25, 3);
        }
    }
}
