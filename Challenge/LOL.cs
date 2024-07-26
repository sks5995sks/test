using System.Reflection.Metadata;

public class LOL{
    public int[] hero_hp = new int[4];
    public int[] hero_mana = new int[4];
    public int[] hero_dmg = new int[4];
    public int[] hero_def = new int[4];
    public int[] hero_type = new int[4];
    public String[] hero_info = new String[4];
    public String[] hero_name = new String[4];
    public String[] hero_skill = new String[4];
    public String[] hero_weapon = new String[4];
    public LOL(){
        hero_name[0] = "티모";
        hero_name[1] = "아리";
        hero_name[2] = "유미";

        hero_info[0] = "티모는 원거리 공격수로 성향에 다양한 성장이 가능합니다. 빠른 이동속도로 치고 빠지는 게릴라식 전투에 능하며 버섯을 이용한 맵 정찰로 팀에 기여할 수 있습니다. 물리 공격 챔피언을 잠시동안 무력화 시킬 수 있으며 패시브를 이용한 매복 공격도 가능합니다.";//티모
        hero_info[1] = "아리는 암살형 마법 딜러로 빠른 기동성과 긴 사정거리를 이용하여 적을 공격하는 챔피언입니다. 또한 고정 데미지와 적을 매혹하는 스킬도 가지고 있어서 다양한 방면에서 활약할 수 있습니다.";//아리
        hero_info[2] = "유미는 아군을 보조하는 데 특화된 서포터 챔피언입니다. '밀착' 상태에선 아군의 능력치를 올려주고, 포탑 이외의 대상에겐 공격을 받지 않는다는 특징을 가지고 있습니다다. '밀착'을 이용한 다채로운 플레이가 가능한 유틸형 서포터로, 강력한 견제와 아군 보조를 수행해냅니다.";//유미
        
        for(int i=0;i<4;i++) hero_weapon[i] = "";

        Console.WriteLine("영웅을 선택하세요.");
        hero_name[4] = Console.ReadLine();
        Console.WriteLine("선택하신 영웅 {0}의 정보를 입력하세요.",hero_name[4]);
        hero_info[3] = Console.ReadLine();//입력
    }
    public static void Main(String[] args){

    }
    public void init(){
        WEAPON w = new WEAPON();
        Console.WriteLine("무슨 영웅의 정보를 확인하시겠습니까?");
        Console.WriteLine("[1. {0}] [2. {1}] [3. {2}] [4. {3}]",hero_name[0],hero_name[1],hero_name[2],hero_name[3]);
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(hero_info[n]);
        Console.WriteLine("{0}의 체력 : ",hero_hp[n]+w.get_hp(n));
        Console.WriteLine("{0}의 마나력 : ",hero_mana[n]+w.get_mana(n));
        Console.WriteLine("{0}의 공격력 : ",hero_dmg[n]+w.get_dmg(n));
        Console.WriteLine("{0}의 방어력 : ",hero_def[n]+w.get_def(n));
        Console.WriteLine("{0}의 속성 : ",hero_type[n]==0?"인간":"야수");
        Console.WriteLine("{0}의 무기 : ",w.get_name(n));

    }
}
public class Character{
    public WEAPON w = new WEAPON();
    public LOL l = new LOL();
    public Character(){
        for(int i=0;i<4;i++){
            l.hero_hp[i] = 150;
            l.hero_mana[i] = 100;
            l.hero_dmg[i] = 15;
            l.hero_def[i] = 20;
        }
        l.hero_type[0] = 1;
        l.hero_type[1] = 0;
        l.hero_type[2] = 1;
    }
    public void attack(){}
    public void skill(){}
}
public class Champion : Character{

    public void attack(){
        Console.WriteLine("몸통박치기");
    }
    public void skill(){
        for(int i=0;i<4;i++) l.hero_skill[i] = "순간이동";
    }
}
public class HUMAN_Cham : Champion{
    public HUMAN_Cham(){
        for(int i=0;i<3+w.check_weapon();i++) 
            if(l.hero_type[i]==0){
                l.hero_def[i] = 50;
                l.hero_mana[i] = 150;
            }
    }
    public void skill(){
        for(int i=0;i<3+w.check_weapon();i++) if(l.hero_type[i]==0) l.hero_skill[i] = "사냥";
    }
}
public class Beast_Cham : Champion{
    public Beast_Cham(){
        for(int i=0;i<3+w.check_weapon();i++) 
            if(l.hero_type[i]==1){
                l.hero_hp[i] = 300;
                l.hero_dmg[i] = 30;
                l.hero_def[i] = 3;
            }
    }
    public void skill(){
        for(int i=0;i<3+w.check_weapon();i++) if(l.hero_type[i]==1) l.hero_skill[i] = "포식";
    }
}
public class WEAPON{
    int[] hp = new int[4];
    int[] mana = new int[4];
    int[] dmg = new int[4];
    int[] def = new int[4];
    String[] name = new String[4];

    public void upgrade_weapon(){
        Console.WriteLine("업그레이드 하실 영웅 번호를 입력하세요.");
        switch(Convert.ToInt32(Console.ReadLine())){
            case 1://티모 
                    name[1] = "모렐로노미콘";
                    hp[1] = 30;
                    mana[1] = 0;
                    dmg[1] = 90;
                    def[1] = 0;
                    break;
            case 2://아리 
                    name[2] = "라바돈의 죽음의 모자";
                    hp[2] = 0;
                    mana[2] = 140;
                    dmg[2] = 0;
                    def[2] = 20;
                    break;
            case 3://유미
                    name[3] = "사라진 양피지";
                    hp[3] = 0;
                    mana[3] = 300;
                    dmg[3] = 15;
                    def[3] = 0;
                    break;
            case 4://입력
                    name[4] = "수호자의 검";
                    hp[4] = 150;
                    mana[4] = 0;
                    dmg[4] = 30;
                    def[4] = 0;
                    break;
        }
        Console.WriteLine("업그레이드가 완료되었습니다.");
    }
    public int check_weapon(){
        LOL l = new LOL();
        return l.hero_weapon[3]!=""?1:0;
    }
    public int get_hp(int idx){
        return hp[idx];
    }
    public int get_mana(int idx){
        return mana[idx];
    }
    public int get_dmg(int idx){
        return dmg[idx];
    }
    public int get_def(int idx){
        return def[idx];
    }
    public String get_name(int idx){
        return name[idx];
    }
}