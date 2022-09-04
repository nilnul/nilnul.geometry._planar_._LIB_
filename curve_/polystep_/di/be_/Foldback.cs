using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.be_
{
	/// <summary>
	/// a u turn.
	/// </summary>
	public class Foldback4dbl : curve_.polystep_.di.Be4dblI
	{
		private nilnul.num.real_.NonnegOfDouble _allowance;

		public nilnul.num.real_.NonnegOfDouble allowance
		{
			get { return _allowance; }
			set { _allowance = value; }
		}


		//public Nonline4dbl(nilnul.num.real_.NonnegOfDoubleI allowance)
		//{
		//}
		public Foldback4dbl(nilnul.num.real_.NonnegOfDouble allowance)
		{
			_allowance = allowance;
			
		}

		public Foldback4dbl(double x):this(new nilnul.num.real_.NonnegOfDouble(x))
		{

		}
		public Foldback4dbl():this(0)
		{

		}
		public bool be(polystep_.Di4dbl obj)
		{
			var vect = obj.inwardReverse.vect;
			var vect1 = obj.outward.vect;

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

		public bool be(Point4dblI basis1, Point4dblI basis2, Point4dblI finish)
		{
			return be(new Di4dbl(basis1, basis2, finish));
			//throw new NotImplementedException();
		}

		static public Foldback4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Foldback4dbl>.Instance;
			}
		}

	}
}
