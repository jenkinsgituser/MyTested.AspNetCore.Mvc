﻿namespace MyTested.AspNetCore.Mvc.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class WebFramework
    {
        public static class Internals
        {
            public static Type RequestCookieCollection
            {
                get
                {
                    var assembly = Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Http"));
                    var type = assembly.GetType("Microsoft.AspNetCore.Http.RequestCookieCollection");
                    return type;
                }
            }

            public static Type DefaultHttpRequest
            {
                get
                {
                    var assembly = Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Http"));
                    var type = assembly.GetType("Microsoft.AspNetCore.Http.DefaultHttpRequest");
                    return type;
                }
            }

            public static Type DefaultHttpResponse
            {
                get
                {
                    var assembly = Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Http"));
                    var type = assembly.GetType("Microsoft.AspNetCore.Http.DefaultHttpResponse");
                    return type;
                }
            }

            public static Type MvcMarkerService
            {
                get
                {
                    var assembly = Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Mvc.Core"));
                    var type = assembly.GetType("Microsoft.Extensions.DependencyInjection.MvcMarkerService");
                    return type;
                }
            }

            public static Type TypeActivatorCache
            {
                get
                {
                    var assembly = Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Mvc.Core"));
                    var type = assembly.GetType("Microsoft.AspNetCore.Mvc.Infrastructure.ITypeActivatorCache");
                    return type;
                }
            }

            public static Type ControllerActionInvokerCache
            {
                get
                {
                    var assembly = Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Mvc.Core"));
                    var type = assembly.GetType("Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvokerCache");
                    return type;
                }
            }

            public static Type ControllerActionInvoker
            {
                get
                {
                    var assembly = Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Mvc.Core"));
                    var type = assembly.GetType("Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker");
                    return type;
                }
            }
        }

        // Copied from the ASP.NET Core source code.
        internal static readonly HashSet<string> AspNetCoreMvcLibraries = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Microsoft.AspNetCore.App",
            "Microsoft.AspNetCore.Mvc",
            "Microsoft.AspNetCore.Mvc.Abstractions",
            "Microsoft.AspNetCore.Mvc.ApiExplorer",
            "Microsoft.AspNetCore.Mvc.Core",
            "Microsoft.AspNetCore.Mvc.Cors",
            "Microsoft.AspNetCore.Mvc.DataAnnotations",
            "Microsoft.AspNetCore.Mvc.Formatters.Json",
            "Microsoft.AspNetCore.Mvc.Formatters.Xml",
            "Microsoft.AspNetCore.Mvc.Localization",
            "Microsoft.AspNetCore.Mvc.NewtonsoftJson",
            "Microsoft.AspNetCore.Mvc.Razor",
            "Microsoft.AspNetCore.Mvc.RazorPages",
            "Microsoft.AspNetCore.Mvc.TagHelpers",
            "Microsoft.AspNetCore.Mvc.ViewFeatures"
        };

        internal static string AspNetCoreMetaPackageName => AspNetCoreMvcLibraries.First();
    }
}
