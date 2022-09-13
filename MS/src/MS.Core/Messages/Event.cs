using System;

namespace MS.Core.Messages
{
    public class Event
    {
        public DateTime TimeStamp { get; private set; }
        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
