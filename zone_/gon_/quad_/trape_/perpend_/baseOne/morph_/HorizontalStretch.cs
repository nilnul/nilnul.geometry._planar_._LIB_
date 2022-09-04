using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trape_.perpend_.baseOne.morph_
{
	/// <summary>
	/// this changes a trapeoid to another trapeoid
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
		/// original is a positive. now changes this to the input, which might be less than , or greater than the upper edge.
		/// </param>
		public HorizontalStretch(PositiveDbl val) : base(val)
		{
		}
		private PositiveDbl _trapeUpper;

		public PositiveDbl trapeUpper
		{
			get { return _trapeUpper; }
			set { _trapeUpper = value; }
		}


		public Point4dblI morph(Point4dblI original)
		{

			return new Point4dbl(
				original.x
				/
				(
					1	// the part that is the base for the stretch
					+
					original.y * (this._trapeUpper.dblen - 1)
				)	//interpret as the proportion of the new upper edge, or horizon segment of line in between.
				* (
					1	// the part that is the base for the stretch
					+
					original.y * (this.boxed.dblen - 1)
				)
				,
				original.y // y wouldnot change as we only stretch it horizontally
			);
			//throw new NotImplementedException();

			/// or we can imagine that the figure is part of a virtual square.
		}
	}
}
