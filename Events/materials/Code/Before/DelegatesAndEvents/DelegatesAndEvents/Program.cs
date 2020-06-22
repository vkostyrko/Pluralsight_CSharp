using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkPerformHandler(int gours, WorkType worktype);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformHandler del1 = new WorkPerformHandler(WorkPerformed1);
            WorkPerformHandler del2 = new WorkPerformHandler(WorkPerformed2);
            WorkPerformHandler del3 = new WorkPerformHandler(WorkPerformed3);

            del1 += del2 + del3;
            
            int finalhours = del1(10, WorkType.Golf);
            Console.WriteLine(finalhours);

            //DoWOrk(del1);
            Console.ReadKey();
        }

        static int DoWOrk(WorkPerformHandler del)
        {
            return del(5, WorkType.GoToMeetings);
        }
        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed 1 called: {hours} hours");
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed 2 called: {hours} hours");
            return hours + 2;
        }

        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed 3 called: {hours} hours");
            return hours + 3;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
