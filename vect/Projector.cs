using nilnul.geometry.planar.vect.op_.unary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{
	public class Projector4dbl
		:
		nilnul.obj.Box_ofIn<planar.Vect4dblI>
	{
		public Projector4dbl(in Vect4dblI val) : base(val)
		{
		}

		public Projector4dbl(Vect4dblI x) : base(x)
		{
		}

		public double dot(
			Vect4dblI x
		) {
			return x.Dot( this.boxed   );
		}
		public double dot(
			
		) {
			return planar.vect.co.to_.real_._DotProductX.Square(this.boxed);
		}

		public Vect4dbl vect(
			Vect4dblI x
		) {
			return ( this.boxed.Scale( dot(x) )   );
		}

		public Vect4dbl vect(
			
		) {
			return ( this.boxed.Scale( dot() )   );
		}

	}
}
