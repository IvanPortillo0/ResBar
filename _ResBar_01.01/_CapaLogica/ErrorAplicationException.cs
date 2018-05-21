using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _CapaLogica
{
    [Serializable]
    public class ErrorAplicationException : Exception
    {
        //Constructores
        public ErrorAplicationException() : base()
        {
            //Constructor vacio.-
        }

        public ErrorAplicationException(String message) : base(message)
        {

        }

        public ErrorAplicationException(String message, Exception innerException)
            : base(message, innerException)
        {

        }

        public ErrorAplicationException(SerializationInfo info, StreamingContext Context)
            : base(info, Context)
        { }
    }
}
