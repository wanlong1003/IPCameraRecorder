using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StreamService.Lib
{
    [ServiceContract]
    public interface IStreamService
    {
        [OperationContract]
        Stream GetFileStream(string filename);

        [OperationContract]
        Stream GetVideoStream(string url, string username, string password);
    }
}
