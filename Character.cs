using System;

namespace Week6InClassWork
{
    abstract class Character
    {
        public virtual void Attack(){
            Console.WriteLine("Your character attacks!");
        }
        public abstract void SpecialMove();
    }
}