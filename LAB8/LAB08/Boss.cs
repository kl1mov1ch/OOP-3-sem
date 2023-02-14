using System;

namespace LAB08
{
    internal class Boss
    {
        event EventHandler Changed;
        
        public int upgrade;  
        public int turn_off;
        public Boss(int power, int Upgrade) 
        {
            turn_off = power;
            upgrade = Upgrade;
        }
        public void Condition()
        {
            
            if (turn_off == 1 || turn_off == 0 && upgrade == 1 || upgrade == 0)
            {
            if (turn_off == 1)
            {
                Console.WriteLine("Boss power on");
            }
            if (turn_off == 0)
            {
                Console.WriteLine("Boss power off");
            }
            if (upgrade == 1)
            {
                Console.WriteLine("Boss upgrade");
            }
            if (upgrade == 0)
            {
                Console.WriteLine("Boss downgrade");
            }
            }
        }
        public void Turn_Off() => turn_off = 0;
        public void Upgrade() => upgrade = 0;
    }
}
