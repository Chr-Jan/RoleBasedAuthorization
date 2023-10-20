using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RoleBasedAuthorization.Models.DTO;

namespace RoleBasedAuthorization.Repositories.Abstract
{
    // IUserAuthenticationService defines authentication and registration service methods
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
