using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Clase7.Authorization.Roles;

namespace Clase7.Roles.Dto
{
    public class RoleMapProfile : Profile
    {
        public RoleMapProfile()
        {
            // Role and permission
            CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            CreateMap<CreateRoleDto, Role>();

            CreateMap<RoleDto, Role>();

            CreateMap<Role, RoleDto>().ForMember(x => x.GrantedPermissions,
                opt => opt.MapFrom(x => x.Permissions.Where(p => p.IsGranted)));

            CreateMap<Role, RoleListDto>();
            CreateMap<Role, RoleEditDto>();
            CreateMap<Permission, FlatPermissionDto>();
        }
    }
}
