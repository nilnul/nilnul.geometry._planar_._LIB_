using nilnul.geometry.planar.grad;
using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.be_
{
	/// <summary>
	/// not in the same line.
	/// the last step might be overlapping the first's extension, or be overlapping the first itself by turning back.
	/// </summary>
	public class Nonline4dbl : curve_.polystep_.di.Be4dblI
	{
		private nilnul.num.real_.NonnegOfDouble _allowanceRatio;

		public nilnul.num.real_.NonnegOfDouble allowanceRatio
		{
			get { return _allowanceRatio; }
			set { _allowanceRatio = value; }
		}


		//public Nonline4dbl(nilnul.num.real_.NonnegOfDoubleI allowance)
		//{
		//}
		public Nonline4dbl(nilnul.num.real_.NonnegOfDouble allowanceRatio0)
		{
			_allowanceRatio = allowanceRatio0;
			
		}

		public Nonline4dbl(double x):this(new nilnul.num.real_.NonnegOfDouble(x))
		{

		}
		public Nonline4dbl():this(0)
		{

		}
		public bool be(polystep_.Di4dbl obj)
		{
			var stokes = planar.cloze_.gon._SurroundedX._Stokes_ofStarted(
				obj.ee
			);

			var grads = obj.grads.ToArray();

			var grad0sq = nilnul.geometry.planar.vect.co.to_.real_._DotProductX.Square(
				grads[0].Vect()
				
			);

			var grad1sq = nilnul.geometry.planar.vect.co.to_.real_._DotProductX.Square(
				grads[1].Vect()
			);

			var normalized1 = stokes / Math.Sqrt (grad0sq * grad1sq);

			return 
				new nilnul.num.real.re_.approx_.Ratio(this.allowanceRatio).re(
					normalized1
					,
					0
				)

				//planar.vector_.nonnil.co._RotationX.Rotation(obj);
				;

			//throw new NotImplementedException();
		}

		public bool be(Point4dblI basis1, Point4dblI basis2, Point4dblI finish)
		{
			return be(
				new Di4dbl(basis1,basis2,finish)
			);
			//throw new NotImplementedException();
		}

		static public Nonline4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nonline4dbl>.Instance;
			}
		}

	}
}
