using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Strategy
    {
        public abstract void Do();
    }
    public class PlayMusic : Strategy
    {
        public override void Do()
        {
            Console.WriteLine("Playing music");
        }
    }
    public class PlayPodcast : Strategy
    {
        public override void Do()
        {
            Console.WriteLine("Playing selected podcast");
        }
    }
    public class ShowLyrics : Strategy
    {
        public override void Do()
        {
            Console.WriteLine("Showing lyrics on the screen");
        }
    }
}
