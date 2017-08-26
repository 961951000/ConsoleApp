﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
   public class User
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
