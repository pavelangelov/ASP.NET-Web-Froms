using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
        context.Response.ContentType = "image/png";

        string text = "";
        if (context.Request.HttpMethod == "GET")
        {
            text = context.Request["q"];
        }
        else if (context.Request.HttpMethod == "POST")
        {
            text = context.Request["postValue"];
        }

        if (text == null)
        {
            text = string.Empty;
        }

        var path = context.Server.MapPath("App_Data/blank.png");
        var bitmap = new Bitmap(path);


        var graphics = Graphics.FromImage(bitmap);
        var brush = new SolidBrush(Color.DarkOrange);
        graphics.FillRectangle(brush, 0, 0, 5000, 150);
        graphics.DrawString(
            text,
            new Font("Bookman Old Style", 12),
            new SolidBrush(Color.BlanchedAlmond),
            new PointF(25, 40));
        context.Response.ContentType = "image/png";
        bitmap.Save(context.Response.OutputStream, ImageFormat.Png);
    }
}