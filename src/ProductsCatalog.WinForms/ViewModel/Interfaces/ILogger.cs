using System;
using System.Threading.Tasks;
using ProductsCatalog.WinForms.DTO.Enums;
using ProductsCatalog.WinForms.DTO.Logging;

namespace ProductsCatalog.WinForms.ViewModel.Interfaces
{
    public interface ILogger<T>  where T : class
    {
        Task LogInformation(string message);

        Task LogWarning(string message);

        Task LogError(string message, LogCriticality criticality);

        Task LogException(Exception exception);
    }
}