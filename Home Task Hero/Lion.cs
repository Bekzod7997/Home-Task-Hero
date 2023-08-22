using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_Hero
{
    internal class Lion : Hero
    {
        public int Normalhealth { get; set; }
        public Lion (int attackStreght, int speed, int health) : base 
            ("Lion", attackStreght, speed, health)
        {
            Normalhealth = normalhealth;
        }
        public const int normalhealth = 2_000;

        public override void Run()
        {
            if(Health < normalhealth) 
            {
                Console.WriteLine($"{Name} is running with speed {0.6 * Speed}");
            }
            else
            {
                base.Run();
            }
        }
    }
}
