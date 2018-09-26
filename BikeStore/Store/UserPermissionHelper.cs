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
        public bool UserIsLogged { get { return _user != null; } }
        public bool UserHasAdminMode { get { return _user != null && _user.AdminMode == true; } }


        public UserPermissionHelper(IIdentity Identity)
        {
            var userId = Identity.GetUserId();
            _user = _db.Users.FirstOrDefault(x => x.Id == userId);
        }
    }
}