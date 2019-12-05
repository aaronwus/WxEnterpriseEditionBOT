using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace wxBotModel.DbModel_Sqlite
{
    public class ModelBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={ _STATIC_DBConfig._STATIC_SQLITE_CONN }");    //创建文件夹的位置        
        }
        public DbSet<WebHooks> webBots { get; set; }
        public DbSet<TaskServers> taskServer { get; set; }
        public DbSet<WebMedia> webMedia { get; set; }
    }
}   
