using System;
using System.IO;
using System.Net;
using System.Text;

namespace Danh_sach_hoc_sinh
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8000/");
            listener.Start();
            Console.WriteLine("Listening...");
              
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                string responseString = "Dddddddcccccccccccccccccc";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                context.Response.ContentLength64 = buffer.Length;
                Stream output = context.Response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
        }
    }
}
