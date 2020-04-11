using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    class ClickedEventArgs
    {
        public ClickedEventArgs(int timeSinceLastClick, int timeButtonHeld)
        {
            TimeSinceLastClick = timeSinceLastClick;
            TimeButtonHeld = timeButtonHeld;
        }

        public int TimeSinceLastClick { get; }

        public int TimeButtonHeld { get; }
    }
}
