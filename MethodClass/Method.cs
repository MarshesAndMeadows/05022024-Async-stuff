using System.Reflection;

namespace MethodClass
{
    public class Method
    {
        public void TimerMethod(int id, int sleeptime, int iterations)
        {
            for (int i = 0;i < iterations; i++)
            {
                Thread.Sleep(sleeptime);
                Console.WriteLine($"Task with ID {id} is done with iteration {i+1}.");
            }
        }

        public int SumTimerMethod(int id, int num1)
        {
            Thread.Sleep (2000);

            int[] result = Enumerable.Range(1, num1).Select(e => Enumerable.Range(1, e).Sum()).ToArray();
            return result[num1-1];
        }
    }
}