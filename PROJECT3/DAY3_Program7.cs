// public class DAY3_Program7{
//     public static void Main(String[] args){
//         Console.WriteLine("생성자 호출 확인");
//         inital2 test1 = new inital2();
//         inital2 tese2 = new inital2(4);
//         inital2 test3 = new inital2(100,"홍길동");
//     }
// }
// class inital2{
//     static inital2(){
//         Console.WriteLine("inital : 클래스 로드시에 무조건 호출");
//     }
//     public inital2(){
//         Console.WriteLine("inital : 인자값 없음");
//     }
//     public inital2(int a){
//         Console.WriteLine("inital : 정수 받음");
//     }
//     public inital2(int a,String name){
//         Console.WriteLine("inital : 정수, 문자열 받음");
//     }
// }