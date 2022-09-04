﻿using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon.vow.ee_
{
	public class VowNeo4Dbl<TVow>
		:
		nilnul.geometry.planar.coil_.gon.vow.Ee4dbl

		where TVow:
		VowI2<coil_.Gon4dblI>
		,
		new()
	{
		public VowNeo4Dbl(coil_.Gon4dblI val)
			:
			base(
			val
			,
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
