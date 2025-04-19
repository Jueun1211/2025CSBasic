namespace _20250405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 아이템의 모양 ♥
            // 아이템의 이름
            // 아이템의 현재 위치
            // 아이템의 기능 : 아이템의 좌표와 플레이어의 좌표가 일치하면 체력을 증가시킨다.

            string shape = "♥";
            string heartName = "하트";
            int heartPosX = 0;
            int heartPosY = 0;
            string heartExplain = "아이템의 좌표와 플레이어의 좌표가 일치하면 체력을 증가시킨다";

            

            
            Scen scene = new Scen();
            Enemy enemy = new Enemy();

            Player player = new Player();


            int MonsterX = 0;
            int MonsterY = 20;
            scene.DrawImage(enemy.Monster, MonsterX, MonsterY);

            while (true)
            {
                MonsterX++;

                scene.DrawImage(player.Player1, MonsterX, MonsterY); //왼쪽

                scene.DrawImage(enemy.Monster, 50, 20);

                Thread.Sleep(1000);

                Console.SetCursorPosition(0+MonsterX,19);
                Console.WriteLine("Hi");

                enemy.RemoveImage(enemy.Monster);

                Thread.Sleep(1000);

                scene.DrawImage(player.Player2, MonsterX, MonsterY); //오른쪽

                Thread.Sleep(1000);

                Console.Clear();

            }


            // for 반복문으로 표현하기



            Console.WriteLine($"아이템의 모양 : {shape}");
            Console.WriteLine($"아이템의 이름 : {heartName}");
            Console.WriteLine($"아이템의 현재 위치 : {heartPosX}, {heartPosY}");
            Console.WriteLine($"아이템의 기능 : {heartExplain}");



        }
    }
}
