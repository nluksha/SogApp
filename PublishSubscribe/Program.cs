using PublishSubscribe.Models;

var publisher = new Publisher();
var subscriber = new Subscriber();

subscriber.Subscribe(publisher);
publisher.Start();

Console.ReadLine();
subscriber.Unsubscribe();
