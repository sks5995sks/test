// public class DAY2_Program3{
//     public static void Main(String[] args){
//         int input = 0;
//         while(true){
//             Console.WriteLine("while문 + switch문을 테스트합니다. 메뉴 번호를 입력해주세요 : ");
//             Console.WriteLine("1. 출력 테스트 2. 프로그램 종료");
//             input = int.Parse(Console.ReadLine()); // 반복문 내 지역변수로 사용, 둘다 수행해보자.
//             switch(input){
//                 case 1:
//                 Console.WriteLine("안녕하세요. 홍길동님 방갑습니다"); // 단순 출력
//                 break;
//                 case 2:
//                 Console.WriteLine("프로그램을 종료합니다.");
//                 break;
//                 default:
//                 Console.WriteLine("잘못입력!!");
//                 break;  
//             }
//             if(input==2){
//                 break;
//             }
//         }
//     }   
// }