using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Home_Task_Hero
{
    internal class Notification
    {
        static void Main(string[] args)
        {
            
            Murlock maurlock = new Murlock(77, 33, 44, 55, 1500);
            Lion lion = new Lion(66, 88, 5300);

            maurlock.Run();
            maurlock.Attack_metod();
            maurlock.Defend();
            maurlock.DisplayInfo();

            lion.Run();
            lion.Attack_metod();
            lion.Defend();
            lion.DisplayInfo();
        }
    }
}
