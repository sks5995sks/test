using System;
using System.IO.Pipes;
using System.Reflection;
using System.Text;
public class DAY3_Program9{
    public static int idx = 3;
    public String[] name = new string[idx];
    public int[] score = new int[idx];

    public DAY3_Program9(){
        for(int i=0;i<idx;i++){
            name[i] = "guest";
            score[i] = 0;
        }
    }

    public static void Main(String[] args){
        //콘솔 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        student std = new student();

        //패스워드 감지
        Console.WriteLine("로그인 필요, 패스워드를 입력하세요 : ");
        int a = 0;
        do{
            a = Convert.ToInt32(Console.ReadLine());
        }while(std.get_psw()!=a);

        std.menu();

    }
}
class student{
    private int psw = 123123;
    DAY3_Program9 main = new DAY3_Program9();
    int idx = DAY3_Program9.idx;

    public int get_psw(){
        return psw;
    }
    public void menu(){
        bool play = true;
        while(play){
            Console.WriteLine("메뉴 선택하세요 : 1. 학생 점수 입력, 2. 학생 점수 출력, 3. 프로그램 종료");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1: inputStudentINFO(); break;
                case 2: outputStudentINFO(); break;
                case 3: play = false; break;
            }
        }
    }
    public void inputStudentINFO()
    {
        Console.WriteLine("학생 이름과 점수를 입력합니다.");
        for(int i = 0; i < idx; i++)
        {
            input1(i);
            input2(i);
        }
        Console.WriteLine("학생 정보 입력 완료!");
    }

    public void input1(int i)
    {
        Console.WriteLine("{0}번 학생의 이름은?", i);
        main.name[i] = Console.ReadLine();
    }

    public void input2(int i)
    {
        Console.WriteLine("{0}번 학생의 점수는?", i);
        main.score[i] = Convert.ToInt32(Console.ReadLine());
    }

    public void outputStudentINFO()
    {
        int sum = 0;
        for(int i = 0; i < idx; i++)
        {
            Console.WriteLine("{0}번 학생의 이름 : {1}, 점수 : {2}", i, main.name[i], main.score[i]);
            sum += main.score[i];
        }
        Console.WriteLine("학생 {0}명의 평균 점수는 {1}점", idx, sum / idx);
    }
}