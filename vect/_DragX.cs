﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{
	/// <summary>
	/// 2d range
	/// </summary>
	/// vs:
	///		<see cref="nilnul.num.real.IRange"/>
	///			both are directional
	///			but this is 1d.
	/// alias:
	///		range
	///			<see cref="nilnul.num.real.range"/>,
	///				which is like <see cref="nilnul.geometry.planar.IGrad"/> exhibiting the property of direction - it can be positive oriented or netative oriented, unlike <see cref="nilnul.num.real.IBound"/>
	///		signed rect
	///		inner product
	///		drag
	///		diag
	///		geometric bivect
	///		clifford
	///		bivect
	///		2-vector
	///		exterior
	///		directed area
	///		wedge
	///		blade
	///		front
	///	vs:
	///		tensor
	///		torgue
	static public class _DragX
	{
		/// <summary>
		/// surround of the drag
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		static public double Surround(this planar.Point4dblI v) {
			return v.x * v.y;
		}
		static public double Surround(planar.Vect4dblI v) {
			return Surround(v.point);
		}

	}
}
