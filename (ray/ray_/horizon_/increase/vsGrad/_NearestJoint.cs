using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.ray_.horizon_.increase.vsGrad
{
	/// <summary>
	/// the intersection can none, 1, or many points among which the nearest is selected;
	/// </summary>
	static public class _NearestJoint
	{

	/// <summary>
	/// the intersection can result:
	///		no point
	///		one point
	///		or many points among which the nearest is selected.
	/// </summary>
		public static double? NearestJoint(
			this Point4dblI rayPivot
			,
			planar.Grad4dbl_byPointsI grad
		)
		{
			var jointByLine = planar.line_.horizon.vsGrad._MaxX.SmallestJoint(
				rayPivot.y
				,
				grad
			);
			if (jointByLine is null)
			{
				return null;
			}
			if (jointByLine < rayPivot.x)
			{
				return null;
			}
			return jointByLine;

		}

	}
}
