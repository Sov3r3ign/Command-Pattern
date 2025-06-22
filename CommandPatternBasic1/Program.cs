using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp theLamp = new Lamp();
            UniversalRemote ur = new UniversalRemote();

            ur.PowerCom = new TurnOnCommand(theLamp);
            ur.MuteCom = new MuteCommand(theLamp);
            ur.PhaseUPCom = new PhaseUPCommand(theLamp);
            ur.PhaseDownCom = new PhaseDownCommand(theLamp);
            ur.Source1Com = new SetSourceCommand(theLamp, "Orange");
            ur.Source2Com = new SetSourceCommand(theLamp, "white");
            ur.Source3Com = new SetSourceCommand(theLamp, "Orange");

            List<CommandBase> commands = new List<CommandBase>();
            commands.Add(new SetSourceCommand(theLamp, "Orange"));
            commands.Add(new PhaseUPCommand(theLamp));
            commands.Add(new PhaseUPCommand(theLamp));
            commands.Add(new PhaseUPCommand(theLamp));
            ur.MacroCom = new MacroCommand(commands);

            ur.Power();
            ur.SetSouce2();

            for(int i = 0; i < 10; ++i)
            {
                ur.PhaseUP();
            }

            ur.Mute();
            ur.SetSouce3();
            ur.Mute();
            ur.Macro();
            ur.Power();
            ur.Power();

            Console.ReadLine();
        }
    }
}
