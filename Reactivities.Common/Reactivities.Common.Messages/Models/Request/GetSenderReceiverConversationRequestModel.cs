namespace Reactivities.Common.Messages.Models.Request;

public class GetSenderReceiverConversationRequestModel
{
    public string SenderUsername { get; set; }
    
    public string ReceiverUsername { get; set; }
    
    public int InitialMessagesLoadCount { get; set; }
    
    public DateTime? DateFrom { get; set; }
    
    public DateTime? DateTo { get; set; }
}