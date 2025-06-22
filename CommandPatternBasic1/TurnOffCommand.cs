using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class TurnOffCommand:CommandBase //ConcreteCommand
    {
        private Lamp theLamp; //receiver
        public TurnOffCommand(Lamp lamp)
        {
            this.theLamp = lamp;
        }
        public void Execute()
        {
            theLamp.TurnLampOff();
        }
        public void Undo()
        {
            theLamp.TurnLampOn();
        }
    }
}
