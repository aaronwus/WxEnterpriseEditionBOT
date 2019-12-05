using System;
using System.Collections.Generic;
using System.Text;

namespace wxBotModel
{
    public class Webhook
    {
        public string name { get; set; }
        public string webHookUrl { get; set; }
        public int states { get; set;  }
        public string webHookKey { get; set;  }
    }
}
