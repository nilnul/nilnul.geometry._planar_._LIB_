﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid.vsPoint
{

	static public class _LayoutDblX
	{
		static  public _layout.Category Layout(planar.grad_.skid_.ByPoints4Dbl arrow, planar.Point4dbl point)
		{
			/// to down dimension
			//var area = nilnul.num.real._SignX.BitNul(
			//	nilnul.geometry.planar.loop_.polygon._SurroundedX.Stokes(arrow.ee.component, arrow.ee.component1, point)
			//);

			switch (
				nilnul.num.real._SignDblX.BitNul(
					nilnul.geometry.planar.coil_.gon._SurroundedX.Stokes(arrow.ee.component, arrow.ee.component1, point)
				)
			)
			{
				case null:
					return (_layout.Category) vsPoint_.colinear._LayoutX._ofColinear(arrow,point);
				case true:
					return _layout.Category.Interior;
				
				default:
					return _layout.Category.External;
					break;
			}


		}
	}
}
