using System;

namespace Week6InClassWork
{
    class Mario : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Mario punches!");
        }
        public override void SpecialMove(){
            Console.WriteLine("Mario throws a firball!");
        }
    }
}