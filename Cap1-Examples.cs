public class EventTrackMessageReceiver : IMessageReceiver
{
    private readonly IEventTrackExtension _eventTrackExtension;
    private readonly IMessagingHubSender _sender;

    public EventTrackMessageReceiver(IMessagingHubSender sender, IEventTrackExtension eventTrackExtension)
    {
        _sender = sender;
        _eventTrackExtension = eventTrackExtension;
    }

    public async Task ReceiveAsync(Message message, CancellationToken cancellationToken)
    {
        await _eventTrackExtension.AddAsync("featureX", "used");
    }
}
