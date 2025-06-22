using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class PhaseUPCommand : CommandBase
    {
        private Lamp theLamp;
        public PhaseUPCommand(Lamp lamp)
        {
            theLamp = lamp;
        }
        public void Execute()
        {
            theLamp.IncreasedPhase();
        }
        public void Undo()
        {
            theLamp.DecreasedPhase();
        }
    }
}
