// public class DAY2_Program27{
//     public static void Main(String[] args){
//         Console.WriteLine("더하기 꼬리 재귀 함수를 시작합니다 : 정수를 입력해주세요");
//         int n = int.Parse(Console.ReadLine());
//         Console.WriteLine("재귀 호출 더하기 결과 : {0}", SumRecursive(n));
//     }
//     public static int SumRecursive(int n,int t = 1){
//         return n==1?t:SumRecursive(n-1,t+n);
//     }
// }