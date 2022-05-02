using Disclone.Contexts;
using Disclone.Models;
using Microsoft.AspNetCore.Mvc;

namespace Disclone.Controllers;

[ApiController]
[Route("messages")]
public class MessageController
{

    private MessageContext context;

    public MessageController(MessageContext myContext)
    {
        context = myContext;
    }
    
    [HttpGet]
    [Route("")]
    public IEnumerable<Message> Get()
    {
        var allMessages = context.Messages;
        return allMessages;
    }

    [HttpPost]
    [Route("")]
    public async Task<Message> Post(Message message)
    {
        var newMessage = new Message
        {
            messageText = message.messageText
        };
        context.Messages.Add(newMessage);
        await context.SaveChangesAsync();
        return newMessage;
    }
}