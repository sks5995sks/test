// public class DAY4_Program14{
//     public static void Main(String[] args){
//         mother mo = new son1();
//         bool isson = (mo is son2); // 엄마가 아들2를 참조하는가?
//         if(isson){
//             Console.WriteLine("업 캐스팅");
//         }
//         else{
//             Console.WriteLine("캐스팅 불가");
//         }
//         son1 so = (mo as son1); // 엄마가 아들1으로 형변환이 가능한가?
//         if(so != null){
//             mo = (son1)so;
//             Console.WriteLine("다운 캐스팅");
//         }
//     }
// }
// public class mother{}
// public class son1 : mother{}
// public class son2 : mother{}