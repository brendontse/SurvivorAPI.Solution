﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Survivor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

//below is in the example for JWT
// using System.IO;
// using Microsoft.AspNetCore;
// using Microsoft.AspNetCore.Hosting;

// namespace WebApi
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             BuildWebHost(args).Run();
//         }

//         public static IWebHost BuildWebHost(string[] args) =>
//             WebHost.CreateDefaultBuilder(args)
//                 .UseStartup<Startup>()
//                 .UseUrls("http://localhost:4000")
//                 .Build();
//     }
// }