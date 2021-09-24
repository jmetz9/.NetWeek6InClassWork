using System;

namespace Week6InClassWork
{
    class Sonic : Character
    {
        public override void Attack(){
            Console.WriteLine("Sonic uses spin punch!");
        }
        public override void SpecialMove(){
            Console.WriteLine("Sonic uses spindash!");
        }
    }
}