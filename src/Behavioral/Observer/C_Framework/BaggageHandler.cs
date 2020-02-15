﻿namespace DesignPatterns.Behavioral.Observer.C_Framework
{
    using System;
    using System.Collections.Generic;

    public class BaggageHandler : IObservable<BaggageInfo>
    {
        private List<BaggageInfo> flights;
        private List<IObserver<BaggageInfo>> observers;

        public BaggageHandler()
        {
            this.observers = new List<IObserver<BaggageInfo>>();
            this.flights = new List<BaggageInfo>();
        }

        // Called to indicate all baggage is now unloaded.
        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, String.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            // Carousel is assigned, so add new info object to list.
            if (carousel > 0 && !flights.Contains(info))
            {
                flights.Add(info);
                foreach (var observer in observers)
                    observer.OnNext(info);
            }
            else if (carousel == 0)
            {
                // Baggage claim for flight is done
                var flightsToRemove = new List<BaggageInfo>();
                foreach (var flight in flights)
                {
                    if (info.FlightNumber == flight.FlightNumber)
                    {
                        flightsToRemove.Add(flight);
                        foreach (var observer in observers)
                            observer.OnNext(info);
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                    flights.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
        }

        public void LastBaggageClaimed()
        {
            foreach (var observer in observers)
                observer.OnCompleted();

            observers.Clear();
        }

        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in flights)
                    observer.OnNext(item);
            }
            return new Unsubscriber<BaggageInfo>(observers, observer);
        }
    }
}
