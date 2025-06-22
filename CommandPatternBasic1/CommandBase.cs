using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    interface CommandBase
    {
        void Execute();
        void Undo();
    }
}
