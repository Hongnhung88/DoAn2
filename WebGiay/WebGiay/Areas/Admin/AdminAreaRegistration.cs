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
               "CategoryAdmin",
               "danh-muc-san-pham",
               new { action = "Index", controller = "CategoryAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "CreateCategoryAdmin",
                "them-moi-danh-muc-san-pham",
                new { action = "Create", controller = "CategoryAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "EditCategoryAdmin",
                "cap-nhat-danh-muc-san-pham/{id}",
                new { action = "Edit", controller = "CategoryAdmin", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "DeleteCategoryAdmin",
                "xoa-danh-muc-san-pham/{id}",
                new { action = "Delete", controller = "CategoryAdmin", id = UrlParameter.Optional }
            );


            context.MapRoute(
               "ProductAD",
               "san-pham-ad",
               new { action = "Index", controller = "ProductAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "ProductCreateAD",
                "them-moi-san-pham-ad",
                new { action = "Create", controller = "ProductAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ProductDetailAD",
                "chi-tiet-san-pham-ad/{id}",
                new { action = "Details", controller = "ProductAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ProductEditAD",
                "cap-nhat-san-pham-ad/{id}",
                new { action = "Edit", controller = "ProductAdmin", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "ProductDeleteAD",
                "xoa-san-pham-ad/{id}",
                new { action = "Delete", controller = "ProductAdmin", id = UrlParameter.Optional }
            );


            context.MapRoute(
               "CommentAD",
               "danh-gia-binh-luan-ad",
               new { action = "Index", controller = "CommentAdmin", id = UrlParameter.Optional }
           );


            context.MapRoute(
               "DeleteCommentAD",
               "xoa-danh-gia-binh-luan-ad/{id}",
               new { action = "Delete", controller = "CommentAdmin", id = UrlParameter.Optional }
           );


            context.MapRoute(
               "OrderAD",
               "don-hang-ad",
               new { action = "Index", controller = "OrdersAdmin", id = UrlParameter.Optional }
           );


            context.MapRoute(
               "OrdersDetailAD",
               "chi-tiet-don-hang-ad/{id}",
               new { action = "Index", controller = "OrderDetailsAdmin", id = UrlParameter.Optional }
           );


            context.MapRoute(
               "LogoutAD",
               "dang-xuat-ad",
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