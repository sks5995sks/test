// using System.Net.Sockets;

// public class DAY2_Program21_2{
//     public static void Main(String[] args){
//         Console.WriteLine("사칙 연산에 필요한 수의 개수는? : ");
//         int idx = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("데이터를 입력합니다 : ");
//         int[] x = new int[idx];
//         for(int i=0;i<idx;i++){
//             Console.WriteLine("{0}번째 데이터를 입력 : ",i);
//             x[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         program_start(x);
//         Console.WriteLine("프로그램을 종료합니다.");
//     }
//     public static void program_start(in int[] x){
//         bool a = true;
//         while(a){
//             Console.Write("계산기 메뉴 : 1. 더하기, 2. 곱하기, 3, 종료 : ");
//             int menu = Convert.ToInt32(Console.ReadLine());
//             switch(menu){
//                 case 1: add(x);break;
//                 case 2: mul(x);break;
//                 case 3: a=false;break; 
//             }
//         }
//     }
//     public static void add(in int[] x){
//         int sum = 0;
//         foreach(int i in x){
//             sum += i;
//         }
//         Console.WriteLine("더하기 결과는 : "+sum);
//     }
//     public static void mul(in int[] x){
//         int sum = 1;
//         foreach(int i in x){
//             sum *= i;
//         }
//         Console.WriteLine("곱하기 결과는 : "+sum);
//     }
// }