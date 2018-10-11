using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Drill
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("This person is no longer employed here.");
        }
    }
}
