using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon_.facade.of_
{
	static  public class _OfClozeByReverseIfNecessaryX
	{

		static public IEnumerable<Point4dblI> _MakeStokesNonneg_assumeStarted(
			IEnumerable<Point4dblI> points
		)
		{
			var surrounded = nilnul.geometry.planar.cloze_.gon._SurroundedX._Stokes_ofStarted(points);
			if (surrounded < 0)
			{
				return points.Reverse();
			}
			return points;
		}

	
	}
}