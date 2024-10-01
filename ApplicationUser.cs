﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSphere.Domain.Entities
{
    internal class ApplicationUser
    {
        //[Required]
        public int AppUserId { get; set; }

        //[Required]
        //[StringLength(50)]
        public string FirstName { get; set; }

        //[Required]
        //[StringLength(50)]
        public string LastName { get; set; }


        //[Required]
        //[StringLength(20)]
        public string NID { get; set; }


        //[Required]
        public string Gender { get; set; }


        //[Required]
        //[StringLength(100)]
        public string Address { get; set; }


        public bool IsDeleted { get; set; } = false;
    }
}
