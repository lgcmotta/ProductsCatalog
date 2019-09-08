using System;
using ProductsCatalog.WinForms.DTO.Enums;

namespace ProductsCatalog.WinForms.DTO.Logging
{
    public class ExceptionLog
    {
        public string ClassName { get; set; }

        public string Message { get; set; }

        public string ExceptionTime { get; set; }

        public string StackTrace { get; set; }

        public string Source { get; set; }

        public string MethodName { get; set; }

        public LogCriticality Criticality { get; set; } 

        public Exception InnerException { get; set; }
    }
}