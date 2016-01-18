﻿using System;
using Nsb.Messages;
using NServiceBus;

namespace Nsb.PriceCalc
{
    public class PriceCalcHandler : IHandleMessages<PriceRequest>
    {
        private readonly IBus _bus;

        public PriceCalcHandler(IBus bus)
        {
            this._bus = bus;
        }

        public void Handle(PriceRequest message)
        {    
            Console.WriteLine();
            Console.WriteLine("Calculating total price...");
            Console.WriteLine("{0} piece for {1} a piece", message.Count, message.Price);

            // wo do not need to configure anything to get this work
            // because we are using Bus.Reply here, the NServiceBus 
            // knows how it has to handle the message forwarding back
            this._bus.Reply(
                new PriceResponse
                {
                    Total = Service.PriceCalculator.GetPrice(message)
                });
        }
    }
}