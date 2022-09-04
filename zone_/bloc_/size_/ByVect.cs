using nilnul.geometry.planar.vect_;
using nilnul.num.real.bound_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.bloc_
{
	public class ByVect4dbl
		:
		nilnul.obj.Box1<
			planar.vect_.NonnilDbl
		>
		,
		tope_.Bloc4dbl_byBoundsI
		
	{
		public ByVect4dbl(NonnilDbl val) : base(val)
		{
		}

		public ClosedDbl boundX => new ClosedDbl(0, boxed.ee.point.x);

		public ClosedDbl boundY => new ClosedDbl(0,boxed.ee.point.y);

		
	}
}
