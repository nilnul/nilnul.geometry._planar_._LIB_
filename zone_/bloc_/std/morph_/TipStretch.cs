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
	public class TipStretch
		:
		nilnul.obj.Box1< nilnul.num.real_.PositiveDbl>
		,
		drawable._morph_.OfPoint4DblI
	{

		private PositiveDbl _newVertical;

		public PositiveDbl newHeight
		{
			get { return _newVertical; }
			set { _newVertical = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// original is 1. now changes this to the input, which might be less than 1, or greater than 1.
		/// </param>
		public TipStretch(PositiveDbl val, PositiveDbl verticalNew) : base(val)
		{
			_newVertical = verticalNew;
		}
		public TipStretch(double x, double y):this(
			new PositiveDbl(x)
			,
			new PositiveDbl(y)
		)
		{

		}

		public TipStretch(PositiveDbl val) : base(val)
		{
		}

		public Point4dblI morph(Point4dblI point)
		{

			return new Point4dbl(
				point.x		//interpret as the proportion of the new upper edge, or horizon line in between. 
				* (
					1	// the part that is the base for the stretch
					+
					point.y * (this.boxed.dblen - 1)
				)
				,
				point.y
				*
				(
					1+
					point.x * (this.newHeight-1)
				)
			);
			//throw new NotImplementedException();
		}
	}
}
