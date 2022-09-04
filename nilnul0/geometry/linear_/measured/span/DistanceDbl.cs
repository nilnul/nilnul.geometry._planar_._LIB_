using nilnul.geometry.linear_._measured;
using nilnul.geometry.linear_.measured.span;
using nilnul.obj._measure_;

namespace nilnul.geometry.linear_.measured.span
{
	public interface Distance4dblI<T> : nilnul.obj.Measure4dblI<T>
		,
		IDistance
		where T: _measured.Unit4dblI
	{
	}

	public interface Distance4dblI :
		//nilnul.obj.Measure4dblI<_measured.Unit4dblI>
		//,
		Distance4dblI<_measured.Unit4dblI>
		,
		IDistance
	{
	}


	public class Distance4dbl<T>
		:
		
		nilnul.obj.Measure4dbl<T>
		,
		Distance4dblI<T>
		//,
		//Distance4dblI
		where T : _measured.Unit4dblI
	{
		public Distance4dbl(num.real_.NonnegOfDoubleI amount, T unit) : base(amount, unit)
		{
		}

		public Distance4dbl(num.real_.NonnegOfDouble amount, T unit) : base(amount, unit)
		{
		}

		public Distance4dbl(double amount, T unit):this(new num.real_.NonnegOfDouble(amount), unit)
		{

		}

		
	}
	public  class Distance4dbl:Distance4dbl<_measured.Unit4dblI>
		,Distance4dblI
	{
		

		public Distance4dbl(double magnitude, _measured.Unit4dblI unit)
			:base(magnitude,unit)
		{
			
		}
		public Distance4dbl(double magnitude):this(magnitude, _measured.Unit4dbl.Singleton)
		{

		}
		public override string ToString()
		{
			return amount.ToString()+unit.ToString();
		}

		static public Distance4dbl operator /(Distance4dbl distance, double x) {
			return new Distance4dbl(distance.amount.realee.ee / 2, distance.unit);
		}
					
	}
}
