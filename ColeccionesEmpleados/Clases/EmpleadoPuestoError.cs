using System;
using System.Runtime.Serialization;

namespace ColeccionesEmpleados.Clases
{
    [Serializable]
    internal class EmpleadoPuestoError : Exception
    {
        public EmpleadoPuestoError()
        {
        }

        public EmpleadoPuestoError(string message) : base(message)
        {
        }

        public EmpleadoPuestoError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmpleadoPuestoError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}