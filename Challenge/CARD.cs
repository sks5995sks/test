using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class CARD{
    public static void Main(String[] args){
        GAME game = new GAME();

        int user_number,computer_number,sum1=0,sum2=0,cnt=0;
        int[] y = new int[2];
        bool play = true,end = false,end_game = false;
        
        while(!end){
            Console.WriteLine("카드 게임을 시작합니다 : 1. 게임 시작, 2. 게임 종료");
            if(Convert.ToInt32(Console.ReadLine())==2){
                play = false;
                end = true;
            }
            while(play){
            switch(game.menu()){
                case 1: y = game.Card_Open();
                        user_number = y[0];
                        computer_number = y[1];
                        sum1 += user_number;
                        sum2 += computer_number;
                        cnt++;
                        Console.WriteLine("{0}번째 플레이어 뽑기 결과 : {1}",cnt,user_number);
                        Console.WriteLine("{0}번째 컴퓨터 뽑기 결과 : {1}",cnt,computer_number);
                        if(cnt==3){
                            play = false;
                            end = true;
                            end_game = true;
                        }
                        break;
                case 2: Console.WriteLine("플레이어 수를 입력하세요.");
                        Console.WriteLine("플레이어 {0}번이 가장 많이 승리했습니다.",game.Card_Auto_Open(Convert.ToInt32(Console.ReadLine())));
                        play = false;
                        end = true;
                        break;
                case 3: play = false;
                        break;
                }
            }
            if(end_game){
                Console.WriteLine("카드 게임 결과 : ");
                if(sum1>sum2){
                    Console.WriteLine("플레이어가 승리했습니다.");
                }else if(sum1<sum2){
                    Console.WriteLine("컴퓨터가 승리했습니다.");
                }else{
                    Console.WriteLine("비겼습니다.");
                }
            }
        } 
    }
}
class GAME{
    public int menu(){
        Console.WriteLine("1. 카드 뽑기(3번 까지 수행) 2. 카드 자동 뽑기 3. 메뉴로 돌아가기");
        return Convert.ToInt32(Console.ReadLine());
    }
    public int[] Card_Open(){
        int[] a = new int[2];
        a[0] = RandomNumberGenerator.GetInt32(1,101);
        a[1] = RandomNumberGenerator.GetInt32(1,101);
        return a;
    }
    public int Card_Auto_Open(int user){
        int[] win = new int[user];
        int[] card = new int[user];
        int i,j;
        for(i=0;i<user;i++) win[i] = 0;
        for(i=0;i<100;i++){
            for(j=0;j<user;j++){
                card[j] = RandomNumberGenerator.GetInt32(1,101);
            }
            win[Array.IndexOf(card,card.Max())]++;
        }
        return Array.IndexOf(win,win.Max());
    }
}