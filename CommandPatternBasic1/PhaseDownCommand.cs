using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class PhaseDownCommand : CommandBase
    {
        private Lamp theLamp;
        public PhaseDownCommand(Lamp lamp)
        {
            theLamp = lamp;
        }
        public void Execute()
        {
            theLamp.DecreasedPhase();
        }
        public void Undo()
        {
            theLamp.IncreasedPhase();
        }
    }
    
}
