using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Interfaces
{
    internal interface ISubscriber
    {
        void Subscribe(IPublisher publisher);
        void Unsubscribe();
    }
}
