using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CustomHandler : IHttpHandler
{
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    public void ProcessRequest(HttpContext context)
    {
        HttpResponse response = context.Response;
        response.ContentType = "text/plain";
        response.Write("Request URL: " + context.Request.Url + "\r\n");
        response.Write("Response date: " + DateTime.Now + "\r\n");
        if (context.Request.HttpMethod == "GET")
        {
            response.Write("Request type: GET\r\n");
            response.Write("Request params: " + context.Request["q"]);
        }
        else if (context.Request.HttpMethod == "POST")
        {
            response.Write("Request type: POST\r\n");
            response.Write("Request params: " + context.Request["postValue"]);
        }
    }
}