﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly.com.Startup))]
namespace Vidly.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
