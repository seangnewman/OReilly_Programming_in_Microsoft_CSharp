namespace Basic_Event_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiate an event publisher object
            EvtPublisher ep = new EvtPublisher();

            //Instantiate an event subscriber object
            EvtSubscriber es = new EvtSubscriber();

            //Point the evt delegate to the subscriber method
            ep.evt += es.HandleTheEvent;
            ep.mEvt += es.HandleTheEvent;


            //Call the checkbalance method on the ep object (publisher)
            ep.CheckBalance(251);



        }
    }
}
