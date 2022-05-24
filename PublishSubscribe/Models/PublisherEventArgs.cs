using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Models
{
    public class PublisherEventArgs: EventArgs
    {
        public int PublisherId { get; set; }
        public string? Message { get; set; }

        public PublisherEventArgs(int id, string message)
        {
            PublisherId = id;
            Message = message;
        }
    }
}
