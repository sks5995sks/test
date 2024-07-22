// public class DAY2_Program17_2{
//     public static void Main(String[] args){
//         Console.InputEncoding = System.Text.Encoding.UTF8;//한국어 입력
//         Console.OutputEncoding = System.Text.Encoding.UTF8;//한국어 출력
//         String[] name_array = ["아저씨", "김새나", "엄마", "아빠", "누나", "형", "동생", "김말아유", "홍길동", "개구리"];
//         Console.WriteLine("이름을 입력합니다.");
//         String name_input = Console.ReadLine();
//         Console.WriteLine(name_input+" "+name_array[2]);
//         int idx = Array.IndexOf(name_array,name_input);
//         if(idx == -1){
//             Console.WriteLine("{0}은 존재하지 않습니다.",name_input);
//         }else{
//             Console.WriteLine("{0}의 위치는 {1}번에 숨어있습니다.",name_input,idx);
//         }
//     }
// }