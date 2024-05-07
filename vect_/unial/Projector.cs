using nilnul.geometry.planar.vect.op_.unary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.unital
{

	public class Projector4dbl
		:
		nilnul.obj.Box_ofIn<planar.vect_.Unital4dblI>
	{

		public Projector4dbl(in Unital4dblI val) : base(val)
		{

		}

		public Projector4dbl(Unital4dblI x) : this(in x)
		{
		}

		public Projector4dbl(Vect4dbl vect4dbl):this(new Unital4dbl(vect4dbl))
		{
		}

		public double length {
			get {

				return 1;
				//return vect._MagnitudeX.Magnitude(boxed);
			}
		}
		public Vect4dblI unital {
			get {
				return this.boxed;
			}
		}



		public double scalar(
				Vect4dblI x
			)
		{
			return vect.co.to_.real_._DotProductX.Dbl(x, boxed);
		}
		public Vect4dbl project(
				Vect4dblI x
			)
		{
			return  this.boxed.Scale(scalar(x) );
		}



	}
}
