using System.Linq;
using System.Security.Principal;
using BikeStore.Models;
using Microsoft.AspNet.Identity;

namespace BikeStore.Store
{
    public class UserPermissionHelper
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        private ApplicationUser _user;
        public bool UserIsLogged { get { return CheckUserIsLogged(); } }
        public bool UserHasAdminMode { get { return CheckUserHasAdminMode(); } }


        public UserPermissionHelper(IIdentity Identity)
        {
            var userId = Identity.GetUserId();
            _user = _db.Users.FirstOrDefault(x => x.Id == userId);
        }

        private bool CheckUserIsLogged()
        {
            bool result = false;

            if (_user != null)
                result = true;

            return result;
        }


        private bool CheckUserHasAdminMode()
        {
            return CheckUserIsLogged() && _user.AdminMode == true;
        }
    }
}