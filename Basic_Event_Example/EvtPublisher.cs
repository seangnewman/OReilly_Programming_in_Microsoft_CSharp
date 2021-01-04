using System;

namespace Basic_Event_Example
{
    class EvtPublisher
    {
        //1. Create delegate
        // Will point to target method in the subscriber
        public delegate void del(string x);
        // Microsoft implementation
        // public EventHandler mEvt;
        public EventHandler<EvtArgsClass> mEvt;

        //2. Create event that will be published 
        // Call this to run the delegate pointed to the target method
        public event del evt;

        //3. Create method to raise the event
        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                // Raise the event
                evt("Attention!  The current balances exceeds $250.....");

                // Microsoft preferred implementation
                EvtArgsClass eac = new EvtArgsClass("Balance exceeds $250");
                mEvt(this, eac);

            }
        }
    }
}
