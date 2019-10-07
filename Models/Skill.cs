﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gride.Models
{
	public class Skill
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int SkillID { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }
	}
}
