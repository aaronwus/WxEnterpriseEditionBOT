using System;
using System.Collections.Generic;
using System.Text;

namespace wxBotModel
{
    /// <summary>
    /// model 图文类型
    /// </summary>
    public class WM_T_News : WM_T_Base
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title">标题，不超过128个字节，超过会自动截断</param>
        /// <param name="description">描述，不超过512个字节，超过会自动截断</param>
        /// <param name="url">点击后跳转的链接。</param>
        /// <param name="picurl">图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图 1068*455，小图150*150。</param>
        public WM_T_News(string title, string description, string url, string picurl)
        {
            msgtype = "news";
            BuilderPackage(title, description, url, picurl);
        }
        public WM_T_Detail_News news { get; set; }
        private void BuilderPackage(string title, string description, string url, string picurl)
        {
            news = new WM_T_Detail_News();
            news.articles = new List<WM_T_Detail_News_Articles>();
            var articles = new WM_T_Detail_News_Articles();
            articles.title = title;
            articles.description = description;
            articles.url = url;
            articles.picurl = picurl;
            news.articles.Add(articles);
        }

    }

    public class WM_T_Detail_News
    {
        public List<WM_T_Detail_News_Articles> articles { get; set; }
    }
    /// <summary>
    /// 图文消息，一个图文消息支持1到8条图文
    /// </summary>
    public class WM_T_Detail_News_Articles
    {
        /// <summary>
        /// 标题，不超过128个字节，超过会自动截断
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 描述，不超过512个字节，超过会自动截断
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 点击后跳转的链接。
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图 1068*455，小图150*150。
        /// </summary>
        public string picurl { get; set; }
    }


}
