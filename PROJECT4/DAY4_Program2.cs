// public class DAY4_Program2{
//     public string Name { get; set; } // 이름 set/get
//     public int Age { get; set; } // 나이 set/get
//     static void Main(String []args){
//         Bird 새 = new Bird(); // 한글 변수도 잘 동작하지만 사용하지는 말자. ㅎ
//         새.Age = 20;
//         새.Name = "훔친새";
//         새.Fly();
//     }
// }
// public class Dog : DAY4_Program2{
//     public void HowOld(){
//         Console.WriteLine("나이: {0}", this.Age); // 부모 클래스의 나이 사용
//     }
// }
// public class Bird : DAY4_Program2{
//     public void Fly(){
//         Console.WriteLine("{0}살 입니다", this.Age);
//         Console.WriteLine("{0}가 날고 있어요!", this.Name);
//     }
// }