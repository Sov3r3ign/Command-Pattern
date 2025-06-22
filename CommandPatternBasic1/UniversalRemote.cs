
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class UniversalRemote //invoker
    {
        public CommandBase PowerCom { get; set; }
        public CommandBase MuteCom { get; set; }
        public CommandBase PhaseUPCom { get; set; }
        public CommandBase PhaseDownCom { get; set; }

        public CommandBase Source1Com { get; set; }
        public CommandBase Source2Com { get; set; }
        public CommandBase Source3Com { get; set; }

        public CommandBase MacroCom { get; set; }

        bool PoweredOn = false;
        bool Muted = false;

        public void Power()
        {
            if (PoweredOn)
            {
                PowerCom.Undo();
            }
            else 
            { 
                
                PowerCom.Execute();  
            
            }

            PoweredOn = !PoweredOn;       
        }
        public void Mute()
        {
            if (Muted)
            {
                MuteCom.Undo();
            }
            else { MuteCom.Execute(); }
            PoweredOn = !PoweredOn;
        }
        public void PhaseUP()
        {
            PhaseUPCom.Execute();
        }
        public void PhaseDown()
        {
            PhaseDownCom.Undo();
        }
        public void SetSouce1()
        {
            Source1Com.Execute();
        }
        public void SetSouce2()
        {
            Source2Com.Execute();
        }
        public void SetSouce3()
        {
            Source3Com.Execute();
        }
        public void Macro()
        {
            MacroCom.Execute();
        }
    }
}
