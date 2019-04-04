using System;
using System.Collections.Generic;

namespace SecurityProject.API.Data
{
    public partial class Roles
    {
        public int RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleDescription { get; set; }
        public sbyte? RoleActiveDefault { get; set; }
        public DateTime? RoleSysdate { get; set; }
    }
}
