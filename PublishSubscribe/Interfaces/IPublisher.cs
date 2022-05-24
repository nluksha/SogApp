using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublishSubscribe.Models;

namespace PublishSubscribe.Interfaces
{
    public interface IPublisher
    {
        event EventHandler<PublisherEventArgs> Started;
        event EventHandler<PublisherEventArgs> Completed;
        void Start();
    }
}
