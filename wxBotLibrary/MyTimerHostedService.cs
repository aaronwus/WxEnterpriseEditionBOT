using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace wxBotLibrary
{
    public class MyTimerHostedService : IHostedService, IDisposable
    {
        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("启动定时任务托管服务");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(10));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            Console.WriteLine("定时任务处理中");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            Console.WriteLine("停止定时任务");
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            // 手动释放定时器
            _timer?.Dispose();
        }
    }
}
