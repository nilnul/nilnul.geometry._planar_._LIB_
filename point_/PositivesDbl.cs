using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point.be_.nil;
using nilnul.geometry.planar.point.be_.nonnil.vow;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.geometry.planar.point_
{

	public class PositivesDbl
		: planar.Point4dblI

	{
		private nilnul.num.real_.PositiveDblI _x;
		public nilnul.num.real_.PositiveDblI xAsPoistive => _x;
		public double x => _x.dblen.ee;

		private nilnul.num.real_.PositiveDblI _y;
		public double y => _y.dblen.ee;

		public PositivesDbl(
			nilnul.num.real_.PositiveDblI x_
			,
			nilnul.num.real_.PositiveDblI _y0
		)

		{
			this._x = x_;
			this._y = _y0;

		}

		static public Point4dbl operator *(double x, PositivesDbl p)
		{
			return new Point4dbl(x * p.x, x * p.y);
		}

		public static PositivesDbl Of(Point4dblI point4dblI)
		{
			return point4dblI switch
			{
				PositivesDbl x=>x
				,
				_ => new PositivesDbl(point4dblI.x, point4dblI.y)
			};
		}

		public PositivesDbl(PositiveDbl x_, PositiveDblI y0) : this(
			(PositiveDblI)(x_)
			,
			y0
		)
		{
		}

		public PositivesDbl(double x_, PositiveDblI y0) : this(
			new PositiveDbl(x_)
			,
			y0
		)
		{
		}

		public PositivesDbl(
			double x_,
		nilnul.num.real_.PositiveDbl _y0
		)
			: this(
				 x_
				 ,
				 (nilnul.num.real_.PositiveDblI)_y0
			)
		{


		}

		public PositivesDbl(double x, double y)
			: this(
				 x
				 ,
				 new nilnul.num.real_.PositiveDbl(y)
		)
		{

		}


	}
}
