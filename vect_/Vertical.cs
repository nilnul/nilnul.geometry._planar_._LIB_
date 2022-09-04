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
	public class Vertical4dbl
		:
		planar.Vect4dbl
		,
		planar.Vect4dblI
	{
		

		public Vertical4dbl(double a) : base(0,a)
		{
		}

		public Vertical4dbl(NonnegOfDoubleI downward):this(downward.realee)
		{
		}
	}

}
