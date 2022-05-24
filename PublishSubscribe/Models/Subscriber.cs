using PublishSubscribe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Models
{
    public class Subscriber : ISubscriber
    {
        private IPublisher? publisher;

        public void Subscribe(IPublisher publisher)
        {
            if (this.publisher == null)
            {
                this.publisher = publisher;
                this.publisher.Started += OnStartedHandler;
                this.publisher.Completed += OnComplitedHandler;
            }
        }

        public void Unsubscribe()
        {
            if (publisher != null)
            {
                publisher.Started -= OnStartedHandler;
                publisher.Completed -= OnComplitedHandler;
                publisher = null;
            }
        }

        private void OnStartedHandler(object sender, PublisherEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void OnComplitedHandler(object sender, PublisherEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
