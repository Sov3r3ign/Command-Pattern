using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class MuteCommand : CommandBase //ConcreteCommand
    {
        private Lamp theLamp; //receiver
        public MuteCommand(Lamp lamp)
        {
            this.theLamp = lamp;
        }
        public void Execute()
        {
            theLamp.Mute();
        }
        public void Undo()
        {
            theLamp.UnMute();
        }
    }
}
