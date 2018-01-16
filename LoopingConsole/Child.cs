using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    class Child
    {
        public string Name { get; set; } // the get and set is a auto property
        public bool Sick { get; set; }

        public string ForgeASickNote()
        {
            return Sick
                ? $"Please excuse {Name} from class today because they are very sick."
                : $"{Name}, you still have to go to school, quit faking. Love mom.";
        }
    }
}
