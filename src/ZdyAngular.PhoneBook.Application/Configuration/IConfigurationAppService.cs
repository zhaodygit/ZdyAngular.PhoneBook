using System.Threading.Tasks;
using ZdyAngular.PhoneBook.Configuration.Dto;

namespace ZdyAngular.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
