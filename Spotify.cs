using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Spotify
    {
        Strategy strategy;
        public Spotify(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public Strategy st
        {
            get { return strategy; }
            set { strategy = value; }
        }
        public void DoIt()
        {
            strategy.Do();
        }
    }
}
