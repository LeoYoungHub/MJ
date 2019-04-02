using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MJ.DAL.EF;
using MJ.DAL.Model;

namespace MJ.DAL
{
    public class PermissionDAL
    {
        public static PermissionDAL Instance = new PermissionDAL();

        public List<Permission> GetPermissions()
        {
            DbSet<Permission> permissions = PermissionContext.Instance.permissions;

            List<Permission> permissionLstList = new List<Permission>();

            foreach (var permission in permissions)
            {
                permissionLstList.Add(permission);
            }

            return permissionLstList;
        }

        public void SavePermission(Permission permission)
        {
            PermissionContext.Instance.permissions.Add(permission);
            int i = PermissionContext.Instance.SaveChanges();
        }
    }
}
