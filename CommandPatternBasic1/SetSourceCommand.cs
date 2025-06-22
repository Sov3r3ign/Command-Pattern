using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class SetSourceCommand : CommandBase
    {
        private Lamp theLamp;
        private string theSource;
        public SetSourceCommand(Lamp lamp, string theSource)
        {
            theLamp = lamp;
            this.theSource = theSource;
        }
        public void Execute()
        {
            theLamp.SetSource(theSource);
        }
        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
    
}
