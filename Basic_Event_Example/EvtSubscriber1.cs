using System;

namespace Basic_Event_Example
{
    class EvtSubscriber
    {
        // 1. Create the target of the delegate from the publisher
        // Must be the same signature as del
        public void HandleTheEvent(string a)
        {
            Console.WriteLine(a);
        }

        //Microsoft Preferred
        public void HandleTheEvent(object sender, EvtArgsClass e)
        {
            Console.WriteLine(String.Format("Attention!  from {0}  : {1}..", sender, e.msg));
        }
    }
}
