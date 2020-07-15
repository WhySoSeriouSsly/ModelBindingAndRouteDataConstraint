using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Models
{
    public class RouteConfig
    {
        public void ConfigureRoute(IRouteBuilder builder)
        {

            builder.MapRoute(
                name:"getid",
                template:"getid/{id?}",
                defaults:new {controller="Home",
                                Action="getid"}
            );
            builder.MapRoute(
                name: "havadurumu",
                template: "hava-durumu",
                defaults: new { controller = "Home", action = "hava" });

            builder.MapRoute(
                name: "gundelik",
                template: "genel-gundelik/{Controller}/{Action}",
                defaults: new { controller = "Home", action = "gundelik" });

            builder.MapRoute(
               name: "gundelik2",
               template: "{Controller}/{Action}/{id?}",
               defaults: new { controller = "Home", action = "deneme" });

            builder.MapRoute(name: "gundelik3",
               template: "hava-durumu2/{id?}",
               defaults: new { controller = "Home", action = "gundelik3" });


            builder.MapRoute(name: "gundelik3kisit",
               template: "hava-durumu3/{id:int?}",
               defaults: new { controller = "Home", action = "gundelik3" });//RouteData Kısıt
        }
    }
}
