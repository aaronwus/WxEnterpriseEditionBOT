using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using wxBotModel;

namespace wxBotLibrary
{
    public static class AddBotConfig
    {
        public static void AddBotConfigs(this IServiceCollection services, IConfiguration configuration)
        {

            _STATIC_WebhookList._static_web_hooks =
                           JsonConvert.DeserializeObject<WebhookList>(File.ReadAllText("wxBotCONFIGS/wxbotConfig.json",Encoding.Default));
            
        }
    }
}
