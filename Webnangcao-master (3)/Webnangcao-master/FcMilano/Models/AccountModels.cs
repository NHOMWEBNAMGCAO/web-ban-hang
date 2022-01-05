using FcMilano.Areas.Admin.Commons;
using FcMilano.Models;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace FcMilano.Models
{
    public class AccountModels
    {
        [Required]
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool Remember { get; set; }

    }
}