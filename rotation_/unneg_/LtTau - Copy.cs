using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.nonneg_
{
	/// <summary>
	/// also know as Direction
	/// </summary>
	public class LtTauOfDbl
		: nilnul.num.real_.nonneg_.LtTauOfDouble
		,RotationOfDoubleI
	{
		public LtTauOfDbl(num.real_.nonneg_.LtTauOfDouble val) : base(val)
		{
		}
		public LtTauOfDbl(double x):this(new num.real_.nonneg_.LtTauOfDouble(x) )
		{

		}

		public _rotation.Unit4dblI unit => _rotation.UnitOfDouble.Singleton;

		public double quantity => ( this);

		static public LtTauOfDbl Create_byCannonize(double r)
		{
			return new LtTauOfDbl(
				nilnul.num.real_.floored._TailX.Doub(r / nilnul.num.real_.TauX.IntoDouble) * nilnul.num.real_.TauX.IntoDouble
			);
		}

		static public Radian4dbl operator -(LtTauOfDbl a, LtTauOfDbl b) {
			return a - b;
		}
	}
}
