using System;
using System.Collections.Generic;
using System.Text;

namespace week8test
{
    class Boss
    {
        private List<Employee> staffs;
        public Boss()
        {
            staffs = Agency.Generate();
        }
        public void Display()
        {
            foreach (Employee e in staffs)
            {
                Console.WriteLine(e);
            }
        }
        public Employee Use(int id)
        {
            foreach (Employee e in staffs)
            {
                if(e.id == id)
                {
                    return e;
                }
            }
            return null;
        }
        public Employee Fire(int id)
        {
            Employee e = Use(id);
            if(e == null)
            {
                return null;
            }
            else
            {
                staffs.Remove(e);
                return e;
            }
        }
    }
}
