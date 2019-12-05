using System;
using System.Collections.Generic;
using System.Text;

namespace wxBotModel
{
    /// <summary>
    /// 图片类型
    /// 注：图片（base64编码前）最大不能超过2M，支持JPG,PNG格式
    /// </summary>
    public class WM_T_Image : WM_T_Base
    {


        public WM_T_Image(string base64, string md5)
        {
            BuilderPackage(base64, md5);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="base64">base64 图片内容的base64编码</param>
        /// <param name="md5">图片内容（base64编码前）的md5值</param>
        private void BuilderPackage(string base64, string md5)
        {
            msgtype = "image";
            image = new WM_T_Detail_Image();
            image.base64 = base64;
            image.md5 = md5;    
        }
         public WM_T_Detail_Image image { get; set;  }
    }
    public class WM_T_Detail_Image
    {
        /// <summary>
        /// 图片内容的base64编码
        /// </summary>
        public string base64 { get; set;  }
        /// <summary>
        /// 图片内容（base64编码前）的md5值
        /// </summary>
        public string md5 { get; set;  }
    }

}
