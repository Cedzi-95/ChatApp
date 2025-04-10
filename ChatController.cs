
using Microsoft.AspNetCore.Mvc;

/*
-vi vill skicka meddelande
-visa meddelande (med timer på frontend)
*/

[ApiController]
[Route("/chat")]
public class ChatController : ControllerBase {

    private static List<ChatMessage> messages = new();
    private readonly ILogger<ChatController>logger;
    [HttpPost]
    public IActionResult CreateMessage([FromBody] CreateMessageRequest request) 
    {
        var message = new ChatMessage(request.Content, request.UserName);
        messages.Add(message);
        return CreatedAtAction(nameof(CreateMessage), message.Id);
    }

    [HttpGet("{lastMessageId}")]
    public ActionResult<IEnumerable<ChatMessage>> GetMessages(int lastMessageId)
    {
        if (lastMessageId >= messages.Count)
        {
            return new List<ChatMessage>();
        }
        return messages[lastMessageId..];
    }
 }

 public class CreateMessageRequest
 {
    public required string Content { get; set; }
    public required string UserName { get; set; }
 }