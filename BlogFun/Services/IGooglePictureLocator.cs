using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlogFun.Services
{
    public interface IGooglePictureLocator
    {
        Task<string> GetProfilePictureAsync(ExternalLoginInfo info);
    }
}