// using System.Formats.Asn1;
// using System.Xml.Serialization;

// class DAY1_Program17{ 
//     public static void Main(String[] args){
        
//         int h,m,p;
//         do{
//             Console.Write("현재 시간을 입력하세요 : ");
//             h = int.Parse(Console.ReadLine());
//         }while(h<0||h>23);

//         do{
//             Console.Write("현재 분을 입력하세요 : ");
//             m = int.Parse(Console.ReadLine());
//         }while(m<0||m>60);
        
//         Console.WriteLine("현재 시간은 {0}시 {1}분입니다.",h,m);
//         do{
//             Console.Write("요리할 시간을 분으로 입력해주세요 : ");
//             p = int.Parse(Console.ReadLine());
//         }while(p<10||p>60);

//         m+=p;

//         if(m>59){
//             m-=60;
//             h++;
//         }

//         if(h>23){
//             h-=24;
//         }
        

//         Console.WriteLine("요리가 완료될 예상 시간은 {0}시 {1}분 입니다.",h,m);
//     }
// }
