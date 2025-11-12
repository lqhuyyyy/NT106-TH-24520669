using System.Text.Json.Serialization;

public class MessageObject
{
    [JsonPropertyName("command")]
    public string Command { get; set; }

    [JsonPropertyName("senderName")]
    public string SenderName { get; set; }

    [JsonPropertyName("recipientName")]
    public string RecipientName { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("fileName")]
    public string FileName { get; set; }

    [JsonPropertyName("fileData")]
    public byte[] FileData { get; set; }
}