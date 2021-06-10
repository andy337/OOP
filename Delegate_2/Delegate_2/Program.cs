using System;


namespace Delegate_2
{
    class Program
    {
        public delegate int Del();
        static void Main(string[] args)
        {
            Del del = new Del(Timer.Count);
            del();
        }
    }
}
