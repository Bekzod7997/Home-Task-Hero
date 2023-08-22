using System.Reflection.Metadata;

namespace Home_Task_Hero
{
    internal class Hero
    {
        public string Name { get; set; }
        public int AttackStrenght { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }

        public Hero(string name, int attackStrenght, int speed, int health)
        {
            Name = name;
            AttackStrenght = attackStrenght;
            Speed = speed;
            Health = health;
        }
        public virtual void Attack_metod()
        {
            Console.WriteLine($"{Name} attacking with strenght {AttackStrenght}");
        }
        public virtual void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
        public virtual void Defend()
        {
            Console.WriteLine($"{Name} is defending");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($" {Name}\n Attack strenght: {AttackStrenght}\n Speed: {Speed}\n" +
                $" Health: {Health}");
            Console.WriteLine();
        }





    }
}