using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace wxBotModel.DbModel_Sqlite
{
    public class WebHooks
    {
        [Key] //主键 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
        public int webBotId { get; set;  }
        public string name { get; set; }
        public string webHookUrl { get; set; }
        public int states { get; set; }
        public string webHookKey { get; set; }
    }

    public class TaskServer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
        public int serId { get; set; }
        public int webBotId { get; set; }
    }

    public class TaskServers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
        public int sersId { get; set;  }
        public int webBotId { get; set;  }
        /// <summary>
        /// 触发类型
        /// 触发一次  1
        /// 手动触发  2
        /// 每月      3
        /// 每周      4
        /// 每天      5
        /// </summary>
        public int triggerType { get; set;  }

        /// <summary>
        /// 月
        /// </summary>
        public int  month { get; set;  }
        /// <summary>
        /// 日
        /// </summary>
        public int day { get; set;  }

        /// <summary>
        /// 时
        /// </summary>
        public int hour { get; set;  }

        /// <summary>
        /// 分
        /// </summary>
        public int min { get; set;  }


        /// <summary>
        /// 周几
        /// </summary>
        public int days { get; set;  }


    }


    public class WebMedia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
        public int ImgId { get; set;  }
        public string ImgSrc { get;set; }
        public string ImgMD5 { get; set;  }
    }


}
