using System;

namespace week8test
{
    class Program
    {
        public delegate Employee ManageWorker(int id);
        static void Main(string[] args)
        {
            Boss boss1 = new Boss();
            boss1.Display();
            /*Employee e1 = boss1.Use(1);
            boss1.Display();*/
            /*Employee e2 = boss1.Fire(1);
            boss1.Display();*/

            Action doSomething; 
            ManageWorker manage;
            doSomething = boss1.Display; 
            manage = boss1.Fire; 
            doSomething(); 
            Console.WriteLine("Dealing with {0}", manage(1));
            doSomething();
        }
    }
}
