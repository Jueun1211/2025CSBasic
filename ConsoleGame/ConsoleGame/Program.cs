/* C# 언어를 사용해서 게임을 만든다.
 * 1. AI를 사용해서 질문을 한다.
 * 2. 이미 만들어진 게임에 기능을 추가하고 싶다. -> 구현된 코드의 의미를 알아야한다.
 * 
 * 목표 1. 숫자의 값이 1~100이다. 이 값을 1 ~ 1000 증가시켜보세요.
 * 목표 2. 숫자를 맞추는 것을 방해하는 요소를 만든다. 정답을 입력할 횟수를 구현하기.
 */



class Program
{
    static void Main(string[] args)
    {
     int maxNumber = 1000; // 목표의 최대 값을 변수로 선언한다.   
        Console.SetCursorPosition(0, 0);
        Random random = new Random();
        int correctNumber = random.Next(1, maxNumber + 1); // 1에서 100 사이의 램덤 숫자
        int userGuess = 0;
        int attemps = 0;
        int maxTryNumber = 10;

        Console.WriteLine("숫자 맞추기 게임에 오신 것을 환영합니다!");
        Console.WriteLine("1부터 1000 사이의 숫자를 맞춰보세요.");
        Console.WriteLine("시도횟수는 10회입니다.");

        while (userGuess != correctNumber)
        {
            Console.Write("추측한 숫자를 입력하세요: ");
            try
            {
                attemps++;
                // attemps = attemps + 1; // 변수 = 데이터, '=' 오른쪽 값을 왼쪽으로 대입한다.
                // attemps = 1
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess < correctNumber)
                {
                    Console.WriteLine("너무 낮아요!");
                }
                else if (userGuess > correctNumber)
                {
                    Console.WriteLine("너무 높아요!");
                }
                else if (userGuess == correctNumber)
                {
                    Console.WriteLine("정답입니다! 🎉");
                }
                if(attemps == maxTryNumber)
                if ( attemps > 9)
                {
                    Console.WriteLine("시도횟수가 초과되었습니다.");
                    break;
                }
            }
            catch
            {
                Console.WriteLine("유효한 숫자를 입력하세요.");
            }
        }
    }
}
