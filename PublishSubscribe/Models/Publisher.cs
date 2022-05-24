using PublishSubscribe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Models
{
    public class Publisher : IPublisher
    {
        private readonly int publisherId;

        public event EventHandler<PublisherEventArgs>? Started;
        public event EventHandler<PublisherEventArgs>? Completed;

        public Publisher()
        {
            var random = new Random();
            publisherId = random.Next();
        }

        public void Start()
        {
            OnStarted();

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);

                OnCompleted();
            });
        }

        protected virtual void OnStarted()
        {
            Started?.Invoke(this, new PublisherEventArgs(publisherId, $"Publisher {publisherId} has been started."));
        }

        protected virtual void OnCompleted()
        {
            Completed?.Invoke(this, new PublisherEventArgs(publisherId, $"Publisher {publisherId} has been completed."));
        }
    }
}
