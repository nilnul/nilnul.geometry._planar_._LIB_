using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.bloc_.std.morph_
{
	/// <summary>
	/// this changes a square to a trapeoid.
	/// </summary>
	public class HorizontalStretch
		:
		nilnul.obj.Box1< nilnul.num.real_.PositiveDbl>
		,
		drawable._morph_.OfPoint4DblI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// original is 1. now changes this to the input, which might be less than 1, or greater than 1.
		/// </param>
		public HorizontalStretch(PositiveDbl val) : base(val)
		{
		}

		public Point4dblI morph(Point4dblI original)
		{

			return new Point4dbl(
				original.x		//interpret as the proportion of the new upper edge, or horizon line in between. 
				* (
					1	// the part that is the base for the stretch
					+
					original.y * (this.boxed.dblen - 1)
				)
				,
				original.y // y wouldnot change as we only stretch it horizontally
			);
			//throw new NotImplementedException();
		}
	}
}
