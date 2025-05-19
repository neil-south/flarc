using Microsoft.AspNetCore.Authorization;
using NHS.Pathways.EdStreamer.Common.Enums;

namespace NHS.Pathways.EdStreamer.PortalApi.Attributes
{
        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
        public class PermissionAuthorizeAttribute : AuthorizeAttribute
        {
            internal const string PolicyPrefix = "PERMISSION:";

            /// <summary>
            /// Creates a new instance of <see cref="AuthorizeAttribute"/> class.
            /// </summary>
            /// <param name="permissions">A list of permissions to authorize</param>
            public PermissionAuthorizeAttribute(params SystemPermission[] permissions)
            {
                Policy = $"{PolicyPrefix}{string.Join(",", permissions.Select(x => x.ToString()))}";
            }
        }
}
