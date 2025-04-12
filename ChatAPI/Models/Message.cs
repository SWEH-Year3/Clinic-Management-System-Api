using System;
using System.Collections.Generic;

namespace ChatAPI.Models;

public partial class Message
{
    public int id { get; set; }

    public string? senderName { get; set; }

    public string? recieverName { get; set; }

    public string? content { get; set; }

    public string? senderID { get; set; }

    public string? recieverID { get; set; }
}
