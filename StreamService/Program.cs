using System;

namespace StreamService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(StreamService.Lib.StreamService));
                host.Open();
                Console.WriteLine("服务已启动......");
            }
            catch (Exception ex)
            {
                Console.WriteLine("启动发生错误：" + ex.Message);
            }
            while (true)
            {
                string key = Console.ReadLine();
                if (string.Compare(key, "exit", true) == 0)
                {
                    break;
                }
            }
        }
    }
}
