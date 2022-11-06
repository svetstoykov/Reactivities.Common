namespace Reactivities.Common.Messages.Models.Response;

public class SenderReceiverConversationResponseModel
{
    public string SenderUsername { get; set; }
    
    public IEnumerable<MessageResponseModel> SenderMessages { get; set; }

    public string ReceiverUsername { get; set; }
    
    public IEnumerable<MessageResponseModel> ReceiverMessages { get; set; }
}