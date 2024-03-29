﻿using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Blog.Core.Interfaces;
using Blog.DataAccess;
using Blog.Services;

namespace Blog.UI.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // Get instance of autofac
            var builder = new ContainerBuilder();
            // registe our controllers, using scan
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // register our context
            builder.RegisterType<BlogContext>().AsSelf();
            builder.RegisterType<ArticleServices>().As<IArticleServices>();
            builder.RegisterType<PollServices>().As<IPollServices>();
            builder.RegisterType<GuestServices>().As<IGuestServices>();
            builder.RegisterType<ProfileServices>().As<IProfileServices>();
            builder.RegisterType<ProfileResultServices>().As<IProfileResultServices>();
            // build our container
            var container = builder.Build();

            // and resolve
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}