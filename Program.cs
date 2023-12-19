using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02_B
{

    class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public void setTime(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
           
        }

        public void displayTime() 
        {
            Console.WriteLine($"{hours}:{minutes}:{seconds}");

        
        }

        public static Time operator +(Time a, Time b) 
        { 

            Time time = new Time();
            time.hours = a.hours + b.hours;
            time.minutes = a.minutes + b.minutes;
            time.seconds = a.seconds + b.seconds;

            if (time.seconds >= 60)
            {
                ++time.minutes;
                time.seconds -= 60;

            }
            
            if (time.minutes >= 60)
            { 
                ++time.hours;
                time.minutes -= 60;
            
            }

            return time;
        
        
        
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Time t1 = new Time();
            t1.setTime(10, 15, 45);
            t1.displayTime();

            Time t2 = new Time();
            t2.setTime(15, 25, 25);
            t2.displayTime();

            Time t3 = new Time();
            t3 = t1 + t2;
            t3.displayTime();
            
        }
    }
}
