﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trail_
{
	public interface IClosed :
		IClosedAtStart
		,
		IClosedAtEnd
	{
	}
}
