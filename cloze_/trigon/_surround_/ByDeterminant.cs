using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.trigon._surround_
{
	static public class _ByDeterminantX
	{

		static public double Surround(
			planar.Point4dblI a
			,
			planar.Point4dblI b
			,
			planar.Point4dblI c
		)
		{

			return parlgrm._surround_._ByDeterminantX.Surround(a,b,c) /2;
		}
	}
}
