using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class TurnOnCommand:CommandBase
    {
        private Lamp theLamp; //receiver
        public TurnOnCommand(Lamp lamp)
        {
            this.theLamp = lamp;
        }
        public void Execute()
        {
            theLamp.TurnLampOn();
        }
        public void Undo()
        {
            theLamp.TurnLampOff();
        }
    }
}
