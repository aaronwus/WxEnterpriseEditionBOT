using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using wxBot.Models;
using wxBotLibrary;
using wxBotModel;

namespace wxBot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// 查看机器人列表
        /// </summary>
        /// <returns></returns>
        public IActionResult WxBotList()
        {
            return View();
        }

        /// <summary>
        /// 查看机器人的任务列表
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> WxBotTasks()
        {
            var d = string.Empty;
            #region Demo
            /*
          //发送文本消息的Demo
          await HttpHelpers.PostStringFromUri(
              "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=3305e544-55d4-4896-a1d8-130aa95a391f",
              new WM_T_Text("BBB")
              );

                               //http://192.168.1.245:40002/111.gif

          发送图文
                                    await HttpHelpers.PostStringFromUri(
             "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=3305e544-55d4-4896-a1d8-130aa95a391f",
             new WM_T_News("发送图文", "图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图 1068*455，小图150*150。", "url", "http://192.168.1.245:40002/220.png")
             );

            //发送med
             await HttpHelpers.PostStringFromUri(
                       "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=3305e544-55d4-4896-a1d8-130aa95a391f",
                       new WM_T_Markdown("> 沙雕测试: <font style='color:red'>test</font> \n >图片:<img src='http://192.168.1.245:40002/111.gif'  />"));
                                */
            #endregion

            await HttpHelpers.PostStringFromUri(
         "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=3305e544-55d4-4896-a1d8-130aa95a391f",
         new WM_T_News("发送图文", "图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图 1068*455，小图150*150。", "url", "http://192.168.1.245:40002/220.png")
         );

            return View();
        }



        public IActionResult wxBotSendMessage(string id)
        {
            ViewData["id"] = id;
            return View();
        }

        /// <summary>
        /// 发送文本
        /// </summary>
        /// <param name="BotUrl"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SendText(string BotUrl, string content)
        {
            var bots = _STATIC_WebhookList._static_web_hooks.webhooks;

            var Url = bots.Where(x => x.webHookKey == BotUrl).FirstOrDefault();
            if (Url == null)
            {
                ViewData["result"] = "failed";
            }
            else
            {
                try
                {
                    await HttpHelpers.PostStringFromUri(Url.webHookUrl, new WM_T_Text(content));
                    ViewData["result"] = "succeed";
                }
                catch (Exception ex)
                {
                    ViewData["result"] = "failed";
                }
            }

            return View();
        }



        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UploadImages([FromServices]IHostingEnvironment environment)
        {
            //List<TmpUrl> list = new List<TmpUrl>();
            var files = Request.Form.Files;
            string webRootPath = environment.WebRootPath;
            string contentRootPath = environment.ContentRootPath;
            var msg = "";
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var exName = formFile.FileName.Split('.')[formFile.FileName.Split('.').Length - 1];
                    if(exName.ToLower()=="png" || exName.ToLower() != "jpg")
                    {
                        var fileName = Guid.NewGuid().ToString() + "." + exName;
                        var path = Path.Combine(environment.WebRootPath + "\\images\\bot", fileName);
                        using (var stream = new FileStream(path, FileMode.CreateNew))
                        {
                            await formFile.CopyToAsync(stream);
                            //TmpUrl tu = new TmpUrl();
                            //tu.Url = @"/images/upload/" + fileName;
                            //list.Add(tu);

                        }
                    }
                    else
                    {
                        msg = "只允许png和jpg";
                        break;
                    }
                }
            }

            return new JsonResult(msg/*list*/);

        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
