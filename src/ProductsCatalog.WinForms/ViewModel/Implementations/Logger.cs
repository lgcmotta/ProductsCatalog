using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ProductsCatalog.ConversionExtensions.Json.Deserialize;
using ProductsCatalog.ConversionExtensions.Json.Serialize;
using ProductsCatalog.WinForms.DTO.Enums;
using ProductsCatalog.WinForms.DTO.Logging;
using ProductsCatalog.WinForms.ViewModel.Interfaces;

namespace ProductsCatalog.WinForms.ViewModel.Implementations
{
    public class Logger<T> : ILogger<T> where T : class
    {
        private readonly string _logFilePath;

        private const string ErrorsFileBaseName = "ProductsCatalog_Errors_";

        private const string InfoFileBaseName = "ProdcutsCatalog_Info_";

        private const string Extension = ".json";

        public Logger()
        {
            _logFilePath = SetLogFilePath();

            CreateLogDirectory();
        }

        private void CreateLogDirectory()
        {
            if (!Directory.Exists(_logFilePath))
                Directory.CreateDirectory(_logFilePath);
        }

        private string SetLogFilePath()
        {
            var sb = new StringBuilder()
                .Append(AppDomain.CurrentDomain.BaseDirectory)
                .Append("Log");

            return sb.ToString();
        }

        private string GetCurrentFileName(string baseFileName)
        {
            var fileDatePart = DateTime.Now.ToString("yyyyMMdd");
            return string.Concat(baseFileName, fileDatePart, Extension);
        }

        private string CreateCurrentFile(string baseFileName)
        {
            var fullPath = string.Concat(_logFilePath, "\\", GetCurrentFileName(baseFileName));

            return fullPath;
        }

        private async Task AppendToLogFile(string fileName,string jsonLogInfo)
        {
            using (var fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    await sw.WriteAsync(jsonLogInfo);
                }
            }
        }

        private async Task<string> GetFileContent(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var sr = new StreamReader(fs))
                {
                    return await sr.ReadToEndAsync();
                }
            }
        }

        private async Task AddMessageToList(MessageLog messageLog)
        {
            var fileName = CreateCurrentFile(InfoFileBaseName);

            var messages = await GetFileContent(fileName);

            var messageLogsList = await messages.DeserializeJsonStringAsync<List<MessageLog>>();
            if(messageLogsList == null)
                messageLogsList = new List<MessageLog>();
            messageLogsList.Add(messageLog);

            await AppendToLogFile(fileName, await messageLogsList.ToJsonStringAsync());
        }

        public async Task LogInformation(string message)
        {
            var messageLog = new MessageLog
            {
                ClassName = typeof(T).Name
                , Criticality = LogCriticality.Info
                , Message = message
                , MessageTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            await AddMessageToList(messageLog);
        }

        public async Task LogWarning(string message)
        {
            var messageLog = new MessageLog
            {
                ClassName = typeof(T).Name
                , Criticality = LogCriticality.Warning
                , Message = message
                , MessageTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            await AddMessageToList(messageLog);
        }

        public async Task LogError(string message, LogCriticality criticality)
        {
            var messageLog = new MessageLog
            {
                ClassName = typeof(T).Name
                , Criticality = criticality
                , Message = message
                , MessageTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            await AddMessageToList(messageLog);
        }

        public async Task LogException(Exception exception)
        {
            var exceptionLog = new ExceptionLog
            {
                ClassName = typeof(T).Name
                , Criticality = LogCriticality.Critical
                , ExceptionTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                , InnerException = exception.InnerException
                , StackTrace = exception.StackTrace
                , Message = exception.Message
                , MethodName = exception.TargetSite.Name
                , Source = exception.Source
            };

            var fileName = CreateCurrentFile(ErrorsFileBaseName);

            var exceptionsContent = await GetFileContent(fileName);

            var exceptionLogs = await exceptionsContent.DeserializeJsonStringAsync<List<ExceptionLog>>();

            exceptionLogs.Add(exceptionLog);

            await AppendToLogFile(fileName,await exceptionLogs.ToJsonStringAsync());
        }
    }
}