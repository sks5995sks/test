// using System.Diagnostics.CodeAnalysis;

// public class DAY2_Program30{
//     public static void Main(String[] args){
//         Console.WriteLine("학생 수를 입력하세요 : ");
//         int idx = Convert.ToInt32(Console.ReadLine());
//         String[] name = new String[idx];
//         int[] score = new int[idx];

//         bool play = true;
//         while(play){
//             Console.WriteLine("메뉴 선택하세요 : 1. 학생 점수 입력, 2. 학생 점수 출력, 3. 프로그램 종료");
//             switch(Convert.ToInt32(Console.ReadLine())){
//                 case 1: inputStudentINFO(ref name,ref score,idx);break;
//                 case 2: outputStudentINFO(ref name,ref score,idx);break;
//                 case 3: play=false;break;
//             }
//         }

//         Console.WriteLine("프로그램을 종료합니다.");
//     }
//     public static void inputStudentINFO(ref String[] name,ref int[] score,in int idx){
//         Console.WriteLine("학생 이름과 점수를 입력합니다.");
//         for(int i=0;i<idx;i++){
//             input(ref name,i);
//             input(ref score,i);
//         }
//         Console.WriteLine("학생 정보 입력 완료!");
//     }
//     public static void input(ref String[] name,int idx){
//         Console.WriteLine("{0}번 학생의 이름은?",idx);
//         name[idx] = Console.ReadLine();
//     }
//     public static void input(ref int[] score,int idx){
//         Console.WriteLine("{0}번 학생의 점수은?",idx);
//         score[idx] = Convert.ToInt32(Console.ReadLine());
//     }
//     public static void outputStudentINFO(ref String[] name,ref int[] score,int idx){
//         int sum = 0;
//         for(int i=0;i<idx;i++){
//             Console.WriteLine("{0}번 학생의 이름 : {1}, 점수 : {2}",i,name[i],score[i]);
//             sum += score[i];
//         }
//         Console.WriteLine("학생 {0}명의 평균 점수는 {1}점",idx,sum/idx);
//     }
// }