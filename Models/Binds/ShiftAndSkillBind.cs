﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gride.Models.Binds
{
	public class ShiftAndSkillBind
	{
		[Key, ForeignKey("Shift")]
		public long ShiftID { get; set; }

		[Key, ForeignKey("Skill")]
		public int SkillID { get; set; }
	}
}
