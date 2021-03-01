using System;
using System.IO;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Experiment();
        }

        public static async Task Experiment()
        {
            Console.WriteLine("Start");
            await Task.Delay(1000);

            string file = @"sample.txt";
            using (FileStream stream = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter stramwriter = new StreamWriter(stream))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        await stramwriter.WriteLineAsync(i.ToString());
                    }
                }
            }
            await Task.Delay(1000);
            Console.WriteLine("end");
        }
    }
}
