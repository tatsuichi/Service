using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Service1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// サービス開始処理
        /// </summary>
        protected override void OnStart(string[] args)
        {
            Logger.Info("サービス開始処理");

            // Set up a timer that triggers every minute.
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000; // 1 seconds
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        /// <summary>
        /// 周期処理
        /// </summary>
        private void OnTimer(object sender, ElapsedEventArgs args)
        {
            Logger.Info("周期処理");
        }

        /// <summary>
        /// サービス停止処理
        /// </summary>
        protected override void OnStop()
        {
            Logger.Info("サービス停止処理");
        }
        /// <summary>
        /// サービス一時停止処理
        /// </summary>
        protected override void OnPause()
        {
            Logger.Info("サービス一時停止");
        }

        /// <summary>
        /// サービス再開処理
        /// </summary>
        protected override void OnContinue()
        {
            Logger.Info("サービス再開");
        }

        /// <summary>
        /// システムシャットダウン処理
        /// </summary>
        protected override void OnShutdown()
        {
            Logger.Info("システムシャットダウン");
        }
    }
}
