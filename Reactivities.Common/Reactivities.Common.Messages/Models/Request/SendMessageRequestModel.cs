namespace Reactivities.Common.Messages.Models.Request;

public class SendMessageRequestModel
{
    public string SenderUsername { get; set; }
        
    public string ReceiverUsername{ get; set; }
        
    public string Content { get; set; }
        
    public DateTime DateSent { get; set; }
}