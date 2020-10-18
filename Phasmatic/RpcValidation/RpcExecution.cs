using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation
{
    public class RpcExecution
    {
        public RpcExecution(PhotonView view, PhotonPlayer source, string name, object[] arguments)
        {
            Received = DateTime.Now;
            Source = source;
            Name = name;
            Arguments = arguments;
            View = view;
        }

        public DateTime Received { get; }
        public PhotonView View { get; }
        public PhotonPlayer Source { get; }
        public string Name { get; }
        public object[] Arguments { get; }
        public RpcValidator Validator { get; set; }
        public bool? IsValid { get; set; }

        public T GetArgument<T>(int index, T defaultObj)
        {
            if (Arguments == null || Arguments.Length <= index) return defaultObj;
            if (Arguments[index] == null) return defaultObj;
            if (!(Arguments[index] is T)) return defaultObj;
            return (T)Arguments[index];
        }

        public T GetArgument<T>(int index)
        {
            return GetArgument(index, default(T));
        }
    }
}
