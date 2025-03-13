using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.re_
{
	/// <summary>
	/// 
	/// </summary>
	public class SameDirection : Re4dblI
	{
		private nilnul.num.real_.NonnegOfDouble _allowance;

		public nilnul.num.real_.NonnegOfDouble allowance
		{
			get { return _allowance; }
			set { _allowance = value; }
		}


		public SameDirection(nilnul.num.real_.NonnegOfDouble allowance)
		{
			_allowance = allowance;
			
		}

		public SameDirection(double x):this(new nilnul.num.real_.NonnegOfDouble(x))
		{

		}
		public SameDirection():this(0)
		{

		}
		public bool re(NonnilDblI a, NonnilDblI b)
		{
			var vect = a;
			var vect1 = b;
			var dotProduct = planar.vect.co.to_.real_._DotProductX.Dbl(
				vect
				,
				vect1
			);


			if (dotProduct<=0)
			{
				return false;
			}

			return
				new nilnul.num.real.re_.approx_.Ratio(this.allowance).re(
					nilnul.num.real.op_.unary_.Square.Singleton.op(dotProduct)
					,

planar.vect.co.to_.real_._DotProductX.Square(vect)
					*
planar.vect.co.to_.real_._DotProductX.Square(vect1)


				);


		}

		public bool re(Vector4dblI vect1, Vector4dblI vect2)
		{
			return re(
				new NonnilDbl(vect1)
				,
				new NonnilDbl(vect2)
			);

		}

		static public SameDirection Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SameDirection>.Instance;
			}
		}

	}
}
