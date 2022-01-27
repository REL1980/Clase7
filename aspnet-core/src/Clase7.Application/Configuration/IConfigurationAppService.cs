using System.Threading.Tasks;
using Clase7.Configuration.Dto;

namespace Clase7.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
