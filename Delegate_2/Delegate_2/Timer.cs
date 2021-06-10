using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_2
{
    class Timer
    {
        public static int Count()
        {
            Console.Write("Кiлькiсть секунд до обновлення: ");
            var seconds = int.Parse(Console.ReadLine());

            TimerCallback tm = new TimerCallback(TimeNow);

            var timer = new System.Threading.Timer(tm, 0, 0, seconds * 1000);
            return 0;

        }
        public static void TimeNow(object obj)
        {

            Console.WriteLine("Час:  " + DateTime.Now.ToLongTimeString());
        }
    }
}
