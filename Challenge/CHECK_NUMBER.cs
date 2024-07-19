public class CHECK_NUMBER{
    public static void Main(String[] args){
        String id = "", gender = "";//주민등록번호 변수 및 성별 변수 초기화
        program_start(ref id);//입력 함수 및 입력 형식 검사 메소드 호출
        //Console.WriteLine(Convert.ToInt64(id));//program_start 메소드의 실행 확인 출력문
        while(number_check(Convert.ToInt64(id),ref gender)){//번호가 제대로 작성 될때까지 반복
            Console.WriteLine("주민번호가 틀립니다.");//비정상시 출력
            program_start(ref id);//다시 입력
        }
        Console.WriteLine("정상 주민번호입니다."+gender);//정상적이라면 출력 후 종료
    }
    public static void program_start(ref String id){//입력 함수 및 입력 형식 검사 메소드
        while(true){//무한 반복
            Console.WriteLine("주민등록 번호를 입력하세요.");
            id = Console.ReadLine();//번호 입력
            if(id.Length==14){//번호의 길이가 14라면
                if(id.IndexOf("--------------")!=-1){//전체가 하이픈일때
                    Console.WriteLine("입력이 틀렸습니다.");//입력 오류 출력
                    continue;//다시 입력
                }else if(id.IndexOf("-",6)==6){//6번 인덱스가 하이픈일때 
                    id = id.Remove(6,1);//6번 인덱스 삭제
                    break;//반복문 탈출
                }else if(id.IndexOf(" ")==6){//6번 인덱스가 공백일때
                    id = id.Remove(6,1);//6번 인덱스 삭제
                    break;//반복문 탈출
                }
                //Console.WriteLine(id+"-");//함수 확인 출력문
            }else if(id.Length==13&&long.TryParse(id,out long y)){//번호 길이가 13이고 숫자일때
                break;//반복문 탈출
            }
            Console.WriteLine("입력이 틀렸습니다.");//위의 조건이 아무것도 맞지 않을때 오류 출력
        }
    }
    public static bool number_check(long num, ref String gender){//주민등록번호 정상여부 및 성별 검증 메소드
        long sum = 0, a=234567892345, last_num = num%10;//합계 변수, 임시변수, 마지막 숫자 저장함수 선언 및 초기화
        num /= 10;//13자리 숫자의 마지막 숫자 제거
        //Console.WriteLine(num+"=");//제거 확인용 출력문
        for(int i=0;i<12;i++){//곱하기 반복문
            long x = a%10, y = num%10;//임시 변수 2개 생성 및 값 할당
            num /= 10;//마지막 자리 없애기
            sum /= 10;//마지막 자리 없애기
            sum += x*y;//없애기 전 마지막 자리의 곱
        }
        gender = last_num%2==0?"여자":"남자";//마지막 숫자가 홀수면 여자, 짝수면 남자 젠더 변수에 저장
        if(11-(sum%11)==last_num) return true;//값이 올바르다면 true 리턴
        return false;//그렇지 않다면 false 리턴
    }
}