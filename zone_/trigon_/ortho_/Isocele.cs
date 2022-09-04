using nilnul.geometry.planar.vect_.nontrivia_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon_.ortho_
{
	public class Isocele4dbl :
		cycle_.trigon_.ortho_.Isocele4dbl
		,
		zone_.Trigon4dblI
	{
		public Isocele4dbl(vect_.horizon_.Positive4dbl val) : base(val)
		{
		}
		public Isocele4dbl(Horizon4dbl val) : this(new vect_.horizon_.Positive4dbl(val))
		{
		}


		public Isocele4dbl(double x) : base(x)
		{
		}

	}
}
