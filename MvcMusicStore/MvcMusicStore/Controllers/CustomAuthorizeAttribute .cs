using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class CustomAuthorizeAttribute:System.Web.Mvc.AuthorizeAttribute
    {
      
        public override void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext)
        {
            if (null == filterContext)
                throw new Exception("filterContext is null");
            var user = filterContext.HttpContext.Session["SessionUserName"];
            
#if DEBUG
  //          return;
#endif

            // 用户为空，赋予Guest
            if (null == user||string.Empty==user.ToString())
            {

                filterContext.Result = new RedirectResult("/Account/LogOn");
                //未登录
              //  filterContext.HttpContext.Response.Write("没有用户登陆");
             //   filterContext.HttpContext.Response.End();
                return;
            }
            //权限验证代码

           //略…..
        } 
    }
}