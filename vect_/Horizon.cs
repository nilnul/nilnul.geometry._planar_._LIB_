using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_
{
	/// <summary>
	/// the vector from one point to another , represented by length and direction
	/// </summary>
	public class Horizon4dbl
		:
		planar.Vect4dbl
		,
		planar.Vect4dblI
	{
		

		public Horizon4dbl(double a) : base(a,0)
		{
		}

		public Horizon4dbl(NonnegOfDoubleI rightward):this(rightward.realee)
		{
		}
	}

}
