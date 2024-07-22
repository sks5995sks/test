// using System.Diagnostics.CodeAnalysis;

// public class DAY2_Program12{
//     public static void Main(String[] args){
//         int n,sum = 0,min,max;
//         Console.Write("차원=1, 길이=");
//         n = Convert.ToInt32(Console.ReadLine());
//         int[] bread = new int[n];
//         Console.WriteLine("숫자를 줄바꿈하여 입력하세요.");
//         for(int i=0;i<n;i++){
//             bread[i] = Convert.ToInt32(Console.ReadLine());
//             sum += bread[i];
//         }
//         Array.Sort(bread);
//         min = bread[0];
//         max = bread[n-1];
//         Console.WriteLine("현재 배열의 최소 값 : {0} 최대 값 : {1}",min, max);
//         Console.WriteLine("먹고 남은 빵의 전체 개수는 {0}개",sum-min-max);
//     }
// }