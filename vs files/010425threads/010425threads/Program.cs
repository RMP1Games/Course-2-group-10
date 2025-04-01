using System;
using System.Threading;

namespace _010425threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fast activate practices

            //PracticeA();
            //PracticeB();
            //PracticeC();

            //Practices
            void PracticeA()
            {
                var PrintNumbers = new Thread(start =>
                {
                    Console.WriteLine("Thread 1 Begin");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("5");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Thread 1 End");
                });
                PrintNumbers.Start();
            }

            void PracticeB()
            {
                var FirstTask = new Thread(start =>
                {
                    Console.WriteLine("Begin 1 task.");
                    Thread.Sleep(2000);
                    Console.WriteLine("End 1 task.");
                });

                var SecondTask = new Thread(start =>
                {
                    Console.WriteLine("Begin 2 task.");
                    Thread.Sleep(1000);
                    Console.WriteLine("End 2 task.");
                });
                FirstTask.Start();
                SecondTask.Start();
                FirstTask.Join();
                SecondTask.Join();
            }

            void PracticeC()
            {
                var counter = 0;
                object locking = new object();
                void IncrementCounter()
                {
                    lock (locking)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            counter++;
                            Thread.Sleep(100);
                        }
                        Console.WriteLine(counter);
                    }
                }

                var thread1 = new Thread(IncrementCounter);
                var thread2 = new Thread(IncrementCounter);
                thread1.Start();
                thread2.Start();
            }
        }
    }
}
