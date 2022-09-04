using nilnul.geometry.linear.point;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad_.based_
{

	/// <summary>
	/// in planar, this is called bloc
	/// </summary>
	public class Bar 
	{
		private linear.PointI _point;

		public linear.PointI point
		{
			get { return _point; }
			set { _point = value; }
		}

		private nilnul.num.real_.NonnegI _length;

		public nilnul.num.real_.NonnegI length
		{
			get { return _length; }
			set { _length = value; }
		}


		public Bar(PointI val, nilnul.num.real_.NonnegI length) 
		{
			this._point = val;
			this._length = length;

		}

		public linear.PointI point1 { get {
				return new linear.Point(
					this._point.x.ToReal() + this._length.realee.en
				);
			} }
	}
}
