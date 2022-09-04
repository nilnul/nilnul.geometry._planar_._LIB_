using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.be_
{
	/// <summary>
	/// </summary>
	public class Forward4dbl : curve_.polystep_.di.Be4dblI
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
		public Forward4dbl(nilnul.num.real_.NonnegOfDouble allowance)
		{
			_allowance = allowance;
			
		}

		public Forward4dbl(double x):this(new nilnul.num.real_.NonnegOfDouble(x))
		{

		}
		public Forward4dbl():this(0)
		{

		}
		public bool be(polystep_.Di4dbl obj)
		{
			return planar.vect_.nonnil.re_.SameDirection.Singleton.re(
			 obj.inward.vect, obj.outward.vect
			 );

			


		}

		public bool be(Point4dblI basis1, Point4dblI basis2, Point4dblI finish)
		{
			return be(new Di4dbl(basis1, basis2, finish));
			//throw new NotImplementedException();
		}

		static public Forward4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Forward4dbl>.Instance;
			}
		}

	}
}
