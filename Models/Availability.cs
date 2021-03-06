﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Localization;

namespace Gride.Models
{
	public class Availability
	{
        public int AvailabilityID { get; set; }
		public DateTime Start { get; set; }
        [EndDateValidator]
        public DateTime End { get; set; }
        public bool Weekly { get; set; } = false;

        public ICollection<EmployeeAvailability> EmployeeAvailabilities { get; set; }
	}
}
