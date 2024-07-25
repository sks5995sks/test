// public class DAY4_Program11{
//     public static void Main(String[] args){
//         Meta_Human2 m = new Meta_Human2();
//         Wonder_woman w = new Wonder_woman();
//         m.skill_1();
//         m.skill_2();
//         w.skill_1();
//         w.skill_2();
//     }
// }
// class Meta_Human2{
//     public void skill_1(){
//         Console.WriteLine("채찍 공격");
//     }
//     public virtual void skill_2(){
//         Console.WriteLine("방패 막기");
//     }
// }
// class Wonder_woman : Meta_Human2{
//     public void skill_1(){
//         Console.WriteLine("불꽃 채찍");
//     }
//     sealed public override void skill_2(){
//         Console.WriteLine("방패 비껴내기");
//     }
// }