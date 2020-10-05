using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Timers;

namespace SampleService
{
    partial class SampleService : ServiceBase
    {
        public SampleService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 30000;
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            var lista = new List<string>();

            for (int i = 0; i < 100000; i++)
            {
                lista.Add("Item " + i);
            }

            byte[] dataAsBytes = lista.SelectMany(s => System.Text.Encoding.UTF8.GetBytes(s + Environment.NewLine)).ToArray();
        }
    }
}
