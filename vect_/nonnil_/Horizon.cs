using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nontrivia_
{
	/// <summary>
	/// the vector from one point to another , represented by length and direction
	/// </summary>
	public class Horizon4dbl
		:
		vect_.Horizon4dbl
		//nilnul.obj.Box1<nilnul.num.real_.PositiveDblI >
		,
		planar.Vect4dblI
	{
		

		public Horizon4dbl( nilnul.num.real_.NonnilDblI val) : base(val.dblee)
		{
		}
		public Horizon4dbl(num.real_. NonnilDbl val) : this((num.real_.NonnilDblI) val)
		{
		}

		
		public Horizon4dbl(PositiveDblI val) : base(val.dblen)
		{
		}
		public Horizon4dbl(PositiveDbl val) : this((PositiveDblI) val)
		{
		}
		public Horizon4dbl(double a) : this(new num.real_. NonnilDbl(a) )
		{
		}



	}

}
