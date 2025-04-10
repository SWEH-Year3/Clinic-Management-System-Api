using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface ITokenRepository
    {
        string CreateToken(UserApplication user, List<string> roles);
    }
}
