using Newtonsoft.Json;

using System;

namespace Using_APIs.Services
{
    public class SerializerService : ISerializerService
    {
        public T Deserialize<T>(string DesData)
        {
            return JsonConvert.DeserializeObject<T>(DesData);
        }

        public string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
