
using System.Threading.Channels;

Characther Player = new Characther(25,0,0,0);
Characther Enemy = new Characther(15, 0, 0, 0);
Player.Print();
Enemy.Print();

class Characther // статы всех персонажей + создание персонажей
{
    public int Armor; // броня, в начале у главного героя == 0
    public int Hp; // здоровье, у героя при старте == 25
    public int Resistance; // сопротивление - психическая броня при старте == 0
    public int Damage; // у героя при старте зависит от оружия

    public Characther(int h, int ar, int rst, int dmg) // конструктор персонажей 
    {
        Hp = h;
        Armor = ar;
        Resistance = rst;
        Damage = dmg;
    }
    public void Print() // метод для теста информации
    {
        Console.WriteLine($"{Hp},{Armor},{Resistance},{Damage}");
    }
}

 internal abstract class Weapon // базовый набор параметров и действий любого оружия
 {
     public abstract int physic_damage { get; } // принимает значение физ.урона от выбранного оружия
    public abstract int psycho_damage { get; } // принимает значение псих.урона от выбранного оружия
    public abstract void Weapon_Attack(); // каждое оружие имеет свою отличную от других реализацию
    

}

class Pistol : Weapon
{
    public override int physic_damage => 4;
    public override int psycho_damage => 0;

    public override void Weapon_Attack()
    {
        Random rnd = new Random();
        int range = rnd.Next(-1, 1);
        Console.WriteLine("бенг! бенг!");
        Console.WriteLine($"урон <{(psycho_damage + psycho_damage) - range}>");
        
    }
}

internal class KnifeAndShield : Weapon
{
    public override int physic_damage => 3;
    public override int psycho_damage => 0;

        public override void Weapon_Attack()
    {
        Random rnd = new Random();
        int range = rnd.Next(-1, 1);
        Console.WriteLine("пцык - дыньг");
        Console.WriteLine($"урон <{(psycho_damage + psycho_damage) - range}>");
    }
}
internal class BagOfCoco : Weapon
{
    public override int physic_damage => 1;
    public override int psycho_damage => 3;

    public override void Weapon_Attack()
    {
        Random rnd = new Random();
        int range = rnd.Next(-1, 2);
        Console.WriteLine("вжух! фууух!");
        Console.WriteLine($"урон <{(psycho_damage + psycho_damage) - range}>");
    }
}
internal class Weed : Weapon
{
    public override int physic_damage => 1;
    public override int psycho_damage => 3;

    public override void Weapon_Attack()
    {
        Random rnd = new Random();
        int range = rnd.Next(-2, 1);
        Console.WriteLine("пшшшшшш! пхааа-ха-ха");
        Console.WriteLine($"урон <{(psycho_damage + psycho_damage) - range}>");
    }
}
internal class MelonThrower : Weapon
{
    public override int physic_damage => 5;
    public override int psycho_damage => 1;
    
    public override void Weapon_Attack()
    {
        Random rnd = new Random();
        int range = rnd.Next(-3, 2);
        Console.WriteLine("кгхххх - птышь!");
        Console.WriteLine($"урон <{(psycho_damage + psycho_damage) - range}>");
    }
}
internal class Machete : Weapon
{
    public override int physic_damage => 5;
    public override int psycho_damage => 0;

    public override void Weapon_Attack()
    {
        Random rnd = new Random();
        int range = rnd.Next(-2, 3);
        Console.WriteLine("вжух! вфух!");
        Console.WriteLine($"урон <{(psycho_damage + psycho_damage) - range}>");
    }
}




