using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_.orient_.flip_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _RealX
	{

		[MethodImpl( MethodImplOptions.AggressiveInlining)]
		public static Point4dbl Point(
			planar.Point4dblI point
		)
		{
			return planar.point.op_.unary_.flip_._AlongVerticalX.Op_retClass(
				point
			);
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining)]
		public static double? Real0nul(
			double? real0nul
		)
		{
			return real0nul is null?null: -real0nul ;
		}

		public static Grad4dbl_byPoints Grad(
			planar.Grad4dbl_byPointsI grad
		)
		{
			return new planar.Grad4dbl_byPoints(
				planar.point.op_.unary_.flip_._AlongVerticalX.Op_retClass(
					grad.basis
				)
				,
				planar.point.op_.unary_.flip_._AlongVerticalX.Op_retClass(
					grad.finish

				)
			);
		}

	}
}
