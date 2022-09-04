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
	/// </summary>
	static public class _NearestJoint
	{

		public static double? NearestJoint(
			this Point4dblI testPoint
			,
			planar.Grad4dbl_byPointsI grad
		)
		{
			var jointByLine = planar.line_.horizon.vsGrad._SmallestJoint.SmallestJoint(
				testPoint.y
				,
				grad
			);
			if (jointByLine is null)
			{
				return null;
			}
			if (jointByLine < testPoint.x)
			{
				return null;
			}
			return jointByLine;

		}

	}
}
