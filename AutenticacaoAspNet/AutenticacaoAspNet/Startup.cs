﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(AutenticacaoAspNet.Startup))]

namespace AutenticacaoAspNet
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "AuthentiocationCookie",
                    LoginPath = new PathString("/Autenticacao/Login")
            });
        }
    }
}