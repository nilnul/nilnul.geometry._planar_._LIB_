﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.cycle_.gon_.quad_
{
	public interface IConvex
		:ITetragon
	{ }
	public interface ConvexI : ITetragon
		,
		IConvex
	{

	}
}
