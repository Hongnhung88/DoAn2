using System.Web.Mvc;

namespace WebGiay.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HomeAD",
                "trang-thong-ke",
                new { action = "Index", controller = "HomeAdmin", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "Admin",
                "admin/index",
                new { action = "Index", controller = "Admin", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "CreateAdmin",
                "them-moi-admin",
                new { action = "Create", controller = "Admin", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "EditAdmin",
                "cap-nhat-admin/{id}",
                new { action = "Edit", controller = "Admin", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "DeleteAdmin",
                "xoa-admin/{id}",
                new { action = "Delete", controller = "Admin", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "LoginAdmin",
                "loginadmin",
                new { action = "Index", controller = "Login", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}