using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribucionDependencias.WebUI.Infrastructure.Abstract
{
    public interface IMembershipProvider
    {
        bool ValidateUser(string username, string password);

    }
}