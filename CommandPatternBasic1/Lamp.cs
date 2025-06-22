using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternBasic1
{
    class Lamp //Receiver
    {
        private bool PowerOn;
        private int phase;
        private string theSource;

        private const int PHASE_MAX = 100;
        private const int PHASE_MIN = 0;
        private int? PreviousPhase;
        public Lamp()
        {
            this.PowerOn = false;
            this.phase = 0;
            this.theSource = "Orange";
        }
        public void TurnLampOn()
        {
            this.PowerOn = true;
            this.phase = this.PreviousPhase == null ? 0 : (int)PreviousPhase;
            Console.WriteLine("Turned lamp on");
            Console.WriteLine("Set volume to {0}",this.phase);
        }
        public void TurnLampOff()
        {
            PowerOn = false ;
            PreviousPhase = phase;
            //this.phase = this.PreviousPhase == null ? 0 : (int)PreviousPhase;
            Console.WriteLine("Turned lamp off");
           // Console.WriteLine("Set volume to {0}", this.phase);
        }
        public void IncreasedPhase()
        {
            phase++;
            if (phase > PHASE_MAX)
                phase = PHASE_MAX;
            Console.WriteLine("Increased volume to {0}", phase);
        }
        public void DecreasedPhase()
        {
            phase--;
            if (phase < PHASE_MIN)
                phase = PHASE_MIN;
            Console.WriteLine("Decreased volume to {0}",phase);
        }
        public void Mute()
        {
            this.PreviousPhase = phase;
            phase = 0;
            Console.WriteLine("Muted phase to {0}",phase);
        }
        public void UnMute()
        {
            phase = (int)PreviousPhase;
            Console.WriteLine("Unmuted phase to {0}", phase);
        }
        public void SetSource(string source)
        {
            theSource = source;
            Console.WriteLine("Set source to {0}", theSource);
        }
    }
}
