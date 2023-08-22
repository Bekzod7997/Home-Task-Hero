using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_Task_Hero
{
    internal class Murlock : Hero
    {
        public int NightAttack { get; set; }
        public int NightSpeed { get; set; }
        public Murlock(int nightattack, int nightspeed, int attackStrenght, int speed, int health)
            : base ("Murlock", attackStrenght, speed, health)
        {
            NightAttack = nightattack;
            NightSpeed = nightspeed;    
        }
        public override void Attack_metod()
        {
            if(DateTime.Now.Hour > 19 || DateTime.Now.Hour < 7) 
            {
                Console.WriteLine($"{Name} with strenght {NightAttack}");
            }
            else
            {
                base.Attack_metod();
            }
        }
        public override void Run()
        {
            if (DateTime.Now.Hour > 19 || DateTime.Now.Hour < 7)
            {
                Console.WriteLine($"{Name} at runnnig with speed {NightSpeed}");
            }
            else
            {
                base.Run();
            }
        }
    }
}