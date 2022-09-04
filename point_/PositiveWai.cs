using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point.be_.nil;
using nilnul.geometry.planar.point.be_.nonnil.vow;
using nilnul.num;

namespace nilnul.geometry.planar.point_
{
	public interface IPositiveWai
		:IPoint

	{
	}
	public class PositiveWai4Dbl
		: planar.Point4dblI

	{
		private double _x;
		public double x => _x;

		private nilnul.num.real_.PositiveDblI _y;
		public double y => _y.dblen.ee;

		public PositiveWai4Dbl(
			double x_,
nilnul.num.real_.PositiveDblI _y0
		)

		{
			this._x = x_;
			this._y = _y0;

		}
		public PositiveWai4Dbl(
			double x_,
nilnul.num.real_.PositiveDbl _y0
		)
			:this(
				 x_
				 ,
				 (nilnul.num.real_.PositiveDblI)_y0
			)
		{
			

		}

		public PositiveWai4Dbl(double x, double y)
			:this(
				 x
				 ,
				 new nilnul.num.real_.PositiveDbl(y)
				)
		{

		}



	}
}
