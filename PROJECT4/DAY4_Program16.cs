// using System.Net.WebSockets;
// using System.Security.Cryptography.X509Certificates;

// public class DAY4_Program16{
//     public static void Main(String[] args){
//         barrak_class b = new barrak_class();
//         b.create_unit();
//     }
// }
// class terran_class{
//     public terran_class(){
//         Console.WriteLine("테란 최상위 클래스");
//     }
//     protected int mineral = 100;
//     int gas;
// }
// class barrak_class : terran_class{
//     public barrak_class(){
//         Console.WriteLine("배럭을 생산합니다.");
//         mineral = 150;
//     }
//     public virtual void skill(){
//         Console.WriteLine("스킬 개발");
//     }
//     public void create_unit(){
//         marine marine = new marine();
//         marine.skill();
//         firebat firebat = new firebat();
//         firebat.skill();
//         medic medic = new medic();
//         medic.skill();
//         ghost ghost = new ghost();
//         ghost.skill();
//     }
// }
// class marine : barrak_class{
//     public marine(){
//         Console.WriteLine("marine을 소환합니다.");
//         mineral = 50;
//     }
//     public override void skill(){
//         Console.WriteLine("스킬[스탬팩]을 사용합니다.");
//     }

// }
// class firebat : barrak_class{
//     public firebat(){
//         Console.WriteLine("firebat을 소환합니다.");
//         mineral = 90;
//     }
//     public override void skill(){
//         Console.WriteLine("스킬[화염방사]을 사용합니다.");
//     }
// }
// sealed class medic : barrak_class{
//     public medic(){
//         Console.WriteLine("medic을 소환합니다.");
//         mineral = 100;
//     }
//     sealed public override void skill(){
//         Console.WriteLine("스킬[치료]을 사용합니다.");
//     }
// }
// class ghost : barrak_class{
//     public ghost(){
//         Console.WriteLine("ghost을 소환합니다.");
//         mineral = 100;
//     }
//     public override void skill(){
//         Console.WriteLine("스킬[핵조준]을 사용합니다.");
//     }
// }