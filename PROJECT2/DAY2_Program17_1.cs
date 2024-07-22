// public class DAY2_Program17_1{
//     public static void Main(String[] args){
//         String[] array = new String[2];
//         int t;
//         array = Console.ReadLine().Split(' ');
//         foreach(String i in array){
//             Console.WriteLine("{0}은 문자열의 길이 및 숫자 포함 검사 결과 {1}",i,int.TryParse(i, out t)&&(array[Array.IndexOf(array,i)].Length==4||array[Array.IndexOf(array,i)].Length==6));
//         }
//     }
// }