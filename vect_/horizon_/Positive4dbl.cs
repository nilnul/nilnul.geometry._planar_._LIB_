using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.horizon_
{
	/// <summary>
	/// </summary>
	public class Positive4dbl
		:
		vect_.Horizon4dbl
		//nilnul.obj.Box1<nilnul.num.real_.PositiveDblI >
		,
		planar.Vect4dblI
	{
		

		
		
		public Positive4dbl(PositiveDblI val) : base(val.dblen)
		{
		}
		public Positive4dbl(PositiveDbl val) : this((PositiveDblI) val)
		{
		}
		public Positive4dbl(double a) : this(new num.real_. PositiveDbl(a) )
		{
		}

		public Positive4dbl(nontrivia_.Horizon4dbl val):this(val.point.x)
		{
		}
	}

}
