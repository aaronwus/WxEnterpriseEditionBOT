using System;
using System.Collections.Generic;
using System.Text;

namespace wxBotModel
{
    public class WM_T_Text
    {
        public WM_T_Text(string conent ,string mentioned_list="",string mentioned_mobile_list="")
        {
            BuilderPackage(conent, mentioned_list, mentioned_mobile_list);
        }
        private void BuilderPackage(string conent, string mentioned_list = "", string mentioned_mobile_list = "")
        {
            msgtype = "text";
            var tmpText = new WM_T_Detail_Test();
            tmpText.content = conent;
            tmpText.mentioned_list = null;
            tmpText.mentioned_mobile_list = null;
            if (!string.IsNullOrEmpty(mentioned_list))
            {
                tmpText.mentioned_list = mentioned_list;
            }
            if (!string.IsNullOrEmpty(mentioned_mobile_list))
            {
                tmpText.mentioned_mobile_list = mentioned_mobile_list;
            }
            text = tmpText;
        }
        /// <summary>
        /// 消息类型，此时固定为text
        /// </summary>
        public string msgtype { get; set; }
        public WM_T_Detail_Test text { get; set; }

    }
    public class WM_T_Detail_Test
    {
        /// <summary>
        /// 文本内容，最长不超过2048个字节，必须是utf8编码
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// userid的列表，提醒群中的指定成员(@某个成员)，@all表示提醒所有人，如果开发者获取不到userid，可以使用mentioned_mobile_list
        /// </summary>
        public string mentioned_list { get; set; }
        /// <summary>
        /// 手机号列表，提醒手机号对应的群成员(@某个成员)，@all表示提醒所有人
        /// </summary>
        public string mentioned_mobile_list { get; set; }

    }
}
