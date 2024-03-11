using System.Threading.Tasks;
using Box.FKs.Configuration.Dto;

namespace Box.FKs.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
