namespace DesignPatterns.Behavioral.Observer.C_Framework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BaggageHandler : IObservable<BaggageInfo>
    {
        private readonly List<BaggageInfo> _flights;
        private readonly List<IObserver<BaggageInfo>> _observers;

        public BaggageHandler()
        {
            this._observers = new List<IObserver<BaggageInfo>>();
            this._flights = new List<BaggageInfo>();
        }

        public void BaggageStatus(int flightNo)
        {
            this.BaggageStatus(flightNo, string.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            if (carousel > 0 && !this._flights.Contains(info))
            {
                this.AddBagInfo(info);
            }
            else if (carousel == 0)
            {
                this.RemoveBagInfo(info);
            }
        }

        public void LastBaggageClaimed()
        {
            foreach (var observer in this._observers)
            {
                observer.OnCompleted();
            }

            this._observers.Clear();
        }

        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            if (!this._observers.Contains(observer))
            {
                this._observers.Add(observer);

                foreach (var item in this._flights)
                {
                    observer.OnNext(item);
                }
            }

            return new UnSubscriber<BaggageInfo>(this._observers, observer);
        }

        private void AddBagInfo(BaggageInfo info)
        {
            this._flights.Add(info);

            foreach (var observer in this._observers)
            {
                observer.OnNext(info);
            }
        }

        private void RemoveBagInfo(BaggageInfo info)
        {
            var flightsToRemove = new List<BaggageInfo>();

            foreach (var flight in this._flights.Where(flight => info.FlightNumber == flight.FlightNumber))
            {
                flightsToRemove.Add(flight);

                foreach (var observer in this._observers)
                {
                    observer.OnNext(info);
                }
            }

            this.RemoveFlights(flightsToRemove);
        }

        private void RemoveFlights(ICollection<BaggageInfo> flightsToRemove)
        {
            foreach (var flightToRemove in flightsToRemove)
            {
                this._flights.Remove(flightToRemove);
            }

            flightsToRemove.Clear();
        }
    }
}
