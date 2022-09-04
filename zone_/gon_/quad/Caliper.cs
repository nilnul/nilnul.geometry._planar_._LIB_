using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad
{
	/// <summary>
	/// the area is: 1/2 * basis * height
	/// </summary>
	public class Caliper
		:
		nilnul.obj.Box_ofIn<zone_.gon_.Quod4dbl>
	{

		/// <summary>
		/// From this point to the opposite point, we get the base.
		/// Then perpendicular to this base, we place a caliper/clampRuler to measure the distance between the two parallel lines, each of which passes thru one of the remaining points.
		/// This will work for both convex and concave quodrilateral.
		/// </summary>
		private nilnul.num.be_.le.vow.ee_.LeThree _baseStart;

		public Caliper(in Quod4dbl val) : base(val)
		{
		}

		public Caliper(Quod4dbl x) : base(x)
		{
		}

		public nilnul.num.be_.le.vow.ee_.LeThree baseStart
		{
			get { return _baseStart; }
			set { _baseStart = value; }
		}


	}
}