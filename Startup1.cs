﻿using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SignalRTest.Startup1))]

namespace SignalRTest
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(); 
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
