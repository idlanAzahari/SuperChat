using System;
using System.Collections.Generic;
using System.Text;

namespace SuperChat.Models
{
    class MessageModel
    {
        public string Username { get; set; }
        public string UsernameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool FirstMessage { get; set; }




    }
}
