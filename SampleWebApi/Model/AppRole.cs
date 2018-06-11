using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SampleWebApi.Model
{
    public class AppRole
    {
        [Required()]
        [Key()]
        public int RoleId { get; set; }

        [Required()]
        public Guid UserId { get; set; }

        [Required()]
        public string RoleName { get; set; }

        [Required()]
        public string RoleDesc { get; set; }
    }
}
