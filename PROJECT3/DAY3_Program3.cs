// public class DAY3_Program3{
//     public static void Main(String[] args){
//         Console.WriteLine("접근 지정자를 구분하자.");
//         string stName = "아저씨";
//         admin_get std = new admin_get(); // 객체 인스턴스 생성
//         std.oldMember1(stName); // public 함수로 접근 가능
//         // std.oldMember2(stName); 에러. 접근 하려면? 접근지정자 필요
//     }
// }
//     class admin_get{
//     public void oldMember1(string name){ // public 으로 지정
//         Console.WriteLine("{0} 선생1. 방갑습니다!", name);
//     }
//     static void oldMember2(string name){ // public이 없으면 기본 private
//         Console.WriteLine("{0} 선생2. 방갑습니다!", name);
//     }
// }