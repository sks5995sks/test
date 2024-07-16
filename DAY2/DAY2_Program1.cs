public class DAY2_Program1{
    public static void Main(String[] args){
        Console.WriteLine("while문을 테스트합니다. 수 한개를 입력하세요 : ");
        int input = Convert.ToInt32(Console.ReadLine());

        while(++input <= 10){
            Console.WriteLine("반복 {0}", input);
        }

        Console.WriteLine("while문을 다시 테스트합니다. 수 한개를 입력하세요 : ");
        input = Convert.ToInt32(Console.ReadLine());
        while(input <= 10){
            Console.WriteLine("반복 {0}",input);
            --input;
            if(input<0){
                break;
            }
        }
    }
}