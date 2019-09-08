using System;
using ProductsCatalog.WinForms.DTO.Enums;

namespace ProductsCatalog.WinForms.DTO.Logging
{
    public class MessageLog
    {
        public string ClassName { get; set; }

        public string Message { get; set; }

        public string MessageTime { get; set; }

        public LogCriticality Criticality { get; set; }
    }
}