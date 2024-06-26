﻿using Common;
using RemotingInterface;
using System;

namespace Interface
{
    public class EventProxy : MarshalByRefObject
    {
        public event MessageArrivedEvent MessageArrived;
        
        public override object InitializeLifetimeService()
        {
            return null;
        }
        
        public void LocallyHandleMessageArrived(Message msg)
        {
            if (MessageArrived != null)
                MessageArrived(msg);
        }
    }
}