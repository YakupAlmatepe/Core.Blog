﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message2
    {
        [Key]
        public string MessageID { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public AppUser SenderUser { get; set; }
        public AppUser ReceiverUser { get; set; }

    }
}