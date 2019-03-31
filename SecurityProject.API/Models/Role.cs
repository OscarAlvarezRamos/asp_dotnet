using System;
using System.ComponentModel.DataAnnotations;

namespace SecurityProject.API.Models
{
    public class Role
    {
        [Key]
        public int role_id { get; set; }
        public string role_code { get; set; }
        public string role_description { get; set; }
        public bool role_active_default { get; set; }
        public DateTime role_system_date { get; set; }
    }
}