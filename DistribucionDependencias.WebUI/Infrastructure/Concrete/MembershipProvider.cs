using System.Web.Security;
using DistribucionDependencias.WebUI.Infrastructure.Abstract;

namespace DistribucionDependencias.WebUI.Infrastructure.Concrete
{
    public class MembershipProvider : IMembershipProvider
    {
        public bool ValidateUser(string username, string password)
        {

            FormsAuthentication.SetAuthCookie(username, false);
            return true;
        }
    }
}