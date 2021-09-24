using System;

namespace Week6InClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.Attack();
            mario.SpecialMove();
            Sonic sonic = new Sonic();
            sonic.Attack();
            sonic.SpecialMove();
        }
    }
}
