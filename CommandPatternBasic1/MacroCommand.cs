using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class MacroCommand:CommandBase
    {
        List<CommandBase> Commands;
        public MacroCommand(List<CommandBase> commands)
        {
            this.Commands = commands;
        }
        public void Execute()
        {
            foreach (CommandBase Current in Commands)
                Current.Execute();
        }
        public void Undo()
        {
            foreach (CommandBase Current in Commands)
                Current.Undo();
        }
    }
}
