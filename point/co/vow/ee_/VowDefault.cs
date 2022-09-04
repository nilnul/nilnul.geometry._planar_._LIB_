﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.vow.ee_
{
	public class VowDefault<TVow> : Ee
		where TVow: co.VowI,new()
	{
		public VowDefault(planar.point.Co val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}