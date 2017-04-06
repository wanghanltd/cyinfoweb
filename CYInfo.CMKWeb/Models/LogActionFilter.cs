using CYInfo.CMKWeb.Help_Codes.Common;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CYInfo.CMKWeb.Models
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext);

        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
           // Log("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
          //  Log("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
          //  Log("OnResultExecuted", filterContext.RouteData);
        }


        private void Log(string methodName, ActionExecutingContext filterContext)
        {

            string logDBDB = "BasicData";
            DefaultMongoDb logMongoFile = new DefaultMongoDb(logDBDB);

            var collection = logMongoFile.database.GetCollection("logUserEvent");
            BsonDocument eventEntity = new BsonDocument();
            try
            {
                
                

                if (HttpContext.Current.User.Identity.IsAuthenticated)
                    eventEntity.Add("UserName", HttpContext.Current.User.Identity.Name);
                else
                    eventEntity.Add("UserName", "");
                //Action Time
                eventEntity.Add("Created", DateTime.Now);
                eventEntity.Add("ActionType", "Executing");
                //RouteTemplate

                //ActionName
                eventEntity.Add("ActionName", filterContext.ActionDescriptor.ActionName);
                //ActionArguments
                eventEntity.Add("ActionArguments", filterContext.ActionParameters.ToBsonDocument());

                //get user ip address
                var myRequest = filterContext.RequestContext.HttpContext.Request;
                eventEntity.Add("IPAddress", GetUserIPAddress(myRequest));


                collection.Save(eventEntity);
            }
            catch (Exception ex)
            {
                //eventEntity.Add("Created", DateTime.Now);
                //eventEntity.Add("Error", ex.Message);
                //collection.Save(eventEntity);
            }
            
        }



        /// <summary>
        /// get user request ip address
        /// </summary>
        /// <param name="myRequest"></param>
        /// <returns></returns>
        private string GetUserIPAddress(HttpRequestBase myRequest)
        {
            string strIP = string.Empty;
            try
            {
                var ip = myRequest.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (!string.IsNullOrEmpty(ip))
                {
                    string[] ipRange = ip.Split(',');
                    int le = ipRange.Length - 1;
                    string trueIP = ipRange[le];
                }
                else
                {
                    ip = myRequest.ServerVariables["REMOTE_ADDR"];
                }
                if (!string.IsNullOrEmpty(ip))
                {
                    strIP = ip.ToString();
                }
            }
            catch (Exception ex)
            {

            }
            return strIP;
        }


    }
}