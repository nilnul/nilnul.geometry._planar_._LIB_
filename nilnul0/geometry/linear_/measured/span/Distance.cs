using nilnul.geometry.linear_._measured;
using nilnul.geometry.linear_._measured;
using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_.measured.span
{
	/// <summary>
	/// a length and a unit
	/// </summary>
	/// <remarks>
	/// in 2d, this is called:
	///		size for a bloc
	///		area for equivalent measured bloc
	/// </remarks>
	public interface IDistance: nilnul.obj.IMeasure
	{
	}
	public interface DistanceI<T> : nilnul.obj.MeasureI<T>
		where T: UnitI
	{ }

	public interface DistanceI : nilnul.obj.MeasureI<UnitI> {
	}

	public class Distance<T>
	:

	nilnul.obj.Measure<T>
	,
	DistanceI<T>
	
	where T : UnitI
	{
		public Distance(num.real_.NonnegI amount, T unit) : base(amount, unit)
		{
		}

		public Distance(num.real_.Nonneg amount, T unit) : base(amount, unit)
		{
		}

		public Distance(nilnul.num.RealI amount, T unit) : this(new num.real_.Nonneg(amount), unit)
		{

		}

		public Distance(nilnul.num.real_.Quotient amount, T unit) : this(new num.real_.Nonneg(amount), unit)
		{

		}




	}


	public class Distance : Distance<UnitI>
		,
		DistanceI
	{
		public Distance(NonnegI amount, UnitI unit) : base(amount, unit)
		{
		}
		public Distance(int i, UnitI unit):this(new Nonneg(i),unit)
		{

		}

		public Distance(RealI amount, UnitI unit) : base(amount, unit)
		{
		}
	}
}
