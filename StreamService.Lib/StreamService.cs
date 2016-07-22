using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StreamService.Lib
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class StreamService : IStreamService
    {
        public System.IO.Stream GetFileStream(string filename)
        {
            string filePath = Path.Combine(System.Environment.CurrentDirectory, "mp4", filename);
            if (!File.Exists(filePath))
            {
                Console.WriteLine("[" + DateTime.Now.ToString() + "]不存在文件:" + filename);
                throw new Exception("[" + DateTime.Now.ToString() + "]不存在文件:" + filename);
            }
            FileStream stream = null;
            try
            {
                Console.WriteLine("[" + DateTime.Now.ToString() + "]读取文件" + filename);
                stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                Console.WriteLine("[" + DateTime.Now.ToString() + "]读取完成" + filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[" + DateTime.Now.ToString() + "]错误：" + ex.Message);
                if (stream != null)
                    stream.Close();
            }
            return stream;
        }

        public Stream GetVideoStream(string url, string username, string password)
        {
            Stream stream = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = new NetworkCredential(username, password);
                request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password));
                WebResponse response = request.GetResponse();
                Console.WriteLine("response.ContentType：" + response.ContentType);

                stream = response.GetResponseStream();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[" + DateTime.Now.ToString() + "]错误：" + ex.Message);
            }
            return stream;
        }
    }
}
