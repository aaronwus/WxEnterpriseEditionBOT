using System;
using System.Collections.Generic;
using System.Text;

namespace wxBotModel
{
    /// <summary>
    /// markdown类型
    /// </summary>
    public class WM_T_Markdown: WM_T_Base
    {

        public WM_T_Markdown(string content)
        {
            BuilderPackage(content);
        }
        /// <summary>
        /// markdown内容，最长不超过4096个字节，必须是utf8编码
        /// </summary>
        /// <param name="content"></param>
        private void BuilderPackage(string content)
        {
            msgtype = "markdown";
            markdown = new WM_T_Detail_Markdown();
            markdown.content = content;
        }
        public WM_T_Detail_Markdown markdown { get; set;  }
    }
    /// <summary>
    /// markdown内容，最长不超过4096个字节，必须是utf8编码
    /// </summary>
    public class WM_T_Detail_Markdown
    {
        /// <summary>
        /// markdown内容，最长不超过4096个字节，必须是utf8编码
        /// </summary>
        public string content { get; set;  }
    }
    /*
     
     {
    "msgtype": "markdown",
    "markdown": {
        "content": "实时新增用户反馈<font color=\"warning\">132例</font>，请相关同事注意。\n
         >类型:<font color=\"comment\">用户反馈</font> \n
         >普通用户反馈:<font color=\"comment\">117例</font> \n
         >VIP用户反馈:<font color=\"comment\">15例</font>"
    }
}

     */
    /*
     目前支持的markdown语法是如下的子集：
     标题 （支持1至6级标题，注意#与文字中间要有空格）
# 标题一
## 标题二
### 标题三
#### 标题四
##### 标题五
###### 标题六

加粗
**bold**
链接
[这是一个链接](http://work.weixin.qq.com/api/doc)
行内代码段（暂不支持跨行）
`code`
引用
> 引用文字
字体颜色(只支持3种内置颜色)
<font color="info">绿色</font>
<font color="comment">灰色</font>
<font color="warning">橙红色</font>

    */

}
