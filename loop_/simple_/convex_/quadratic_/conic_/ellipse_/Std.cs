using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.loop_.simple_.convex_.quadratic_.conic_.ellipse_
{
	/// <summary>
	/// centered around origin.
	/// </summary>
	public class Std:IEllipse
	{
		private nilnul.num.real_.PositiveDblI _majorRadius;

		public nilnul.num.real_.PositiveDblI majorRadius
		{
			get { return _majorRadius; }
			set { _majorRadius = value; }
		}

		private nilnul.num.real_.PositiveDblI _minorRadius;

		public nilnul.num.real_.PositiveDblI minorRadius
		{
			get { return _minorRadius; }
			set { _minorRadius = value; }
		}



		public bool has(planar.Point4dblI point) {

			return nilnul.num.real.op_.unary_.Square.Singleton.op(point.x) / nilnul.num.real.op_.unary_.Square.Singleton.op(_majorRadius.dblen)
				+
nilnul.num.real.op_.unary_.Square.Singleton.op(point.y) / nilnul.num.real.op_.unary_.Square.Singleton.op(_minorRadius.dblen)
== 1;
		}
	}
}
