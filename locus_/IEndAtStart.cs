﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.locus_
{
	/// <summary>
	/// clozed. might self intersected like the 8 shaped bee flying locus or train track.
	/// </summary>
	/// <see cref="planar.ILasso"/>
	public interface IEndAtStart : ILocus, trail_.IEndAtStart
	{
	}
}
