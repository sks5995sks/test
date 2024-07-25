// using System.Runtime.CompilerServices;

// public class DAY3_Program22{
//     public static void Main(String[] args){
//         Object_init ob = new Object_init();
//         ob.program();
//     }
// }
// class Calculator{
//     int x,y,z;
//     ~Calculator(){
//         x = y = z = 0;
//     }
//     public int Calculator_start_menu(){
//         Console.WriteLine("게산기 s/w를 시작합니다.(초기화 완료)");
//         Console.WriteLine("계산기 : 1.숫자 입력 2.더하기 3.빼기 4.곱하기 5.프로그램 종료");
//         return Convert.ToInt32(Console.ReadLine());
//     }
//     public void Calculator_print_value(int a){
//         switch(a){
//             case 2:z=x+y;break;
//             case 3:z=x-y;break;
//             case 4:z=x*y;break;
//         }
//         Console.WriteLine(z);
//     }
//     public void Calculator_input_value(){
//         x = Convert.ToInt32(Console.ReadLine());
//         y = Convert.ToInt32(Console.ReadLine());
//     }
// }
// public class Object_init{
//     Calculator c = new Calculator();
    
//     public void program(){
//         while(true){
//             int menu = c.Calculator_start_menu();
//             if(menu == 1) c.Calculator_input_value();
//             else if(menu == 5) break;
//             else c.Calculator_print_value(menu);
//         }
//         Console.WriteLine("프로그램을 종료합니다.");
//     }
// }