using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.op_.unary_
{
	static public class _NegX
	{
		static public planar.Vector1 Neg(this planar.IVector vector) {
			return new Vector1(
				planar.point.convert_.Neg.Singleton.convert(
					vector.point
				)
			);
		}





	}

	public class Neg4dbl : op_.Unary4dblA
		,
		Unary4dblI1
	{
		public override VectorDbl op(VectorDbl par)
		{
			return -par;
			//throw new NotImplementedException();
		}


		static public Neg4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Neg4dbl>.Instance;
			}
		}

		public  Vect4dblI op(Vect4dblI vector)
		{
			return new Vect4dbl(
				-vector.point.x
				,
				-vector.point.y
			);
		}
	}
}
