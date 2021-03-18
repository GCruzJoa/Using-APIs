using System;
using System.Collections.Generic;
using System.Text;

namespace Using_APIs.Services
{
    public interface ISerializerService
    {
        string Serialize(object data);
       T Deserialize<T>(string DesData);
    }
}
