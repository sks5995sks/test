public class DAY2_Program7_1{
    public static void Main(String[] args){
        String psw;
        
        for(int i=1;i<6;i++){
            Console.WriteLine("비밀번호 입력하기 : ");
            psw = Console.ReadLine();

            if(psw.Length<6||psw.Length>9){ 
                Console.WriteLine("로그인 실패, 5회 제한 : 현재 {0}회",i);
                continue;
            }

            if(psw == "123123"){
                Console.WriteLine("로그인 성공!");
                break;
            }
            else Console.WriteLine("패스워드가 틀립니다!");

            Console.WriteLine("로그인 실패, 5회 제한 : 현재 {0}회",i);
            
        }
    }
}