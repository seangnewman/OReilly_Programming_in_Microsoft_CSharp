using System;

namespace Basic_Event_Example
{
    public class EvtArgsClass : EventArgs
    {
        public readonly string msg;

        public EvtArgsClass(string str)
        {
            msg = str;
        }


    }
}
