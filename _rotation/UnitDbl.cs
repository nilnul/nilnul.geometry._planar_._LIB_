using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._rotation
{
	public interface Unit4dblI
		:nilnul.obj._measure.Unit4dblI
	{
	}

	[Obsolete(nameof(Unit4dblI))]
	public interface UnitOfDoubleI
		:Unit4dblI
	{
		[Obsolete(nameof(nilnul.obj._measure.Unit4dblI.magnitude))]
		double asRadian { get; }
	}

	public abstract class Unit4dblA
		:
		nilnul.obj._measure.Unit4dblA
		,
		Unit4dblI
	{
		protected Unit4dblA(PositiveDblI val) : base(val)
		{
		}

		protected Unit4dblA(PositiveDbl x) : base(x)
		{
		}

		protected Unit4dblA(double x) : base(x)
		{
		}
	}

	public class Unit4dbl
		:
		Unit4dblA
	{
		public Unit4dbl() : base(1)
		{
		}
	}

	/// <summary>
	/// aka: radian
	/// </summary>
	public class UnitOfDouble
		:
		nilnul.obj._measure.Unit4dbl
		,
		UnitOfDoubleI
	{
		public double asRadian => this.magnitude.dblen.ee;


		static public UnitOfDouble Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<UnitOfDouble>.Instance;
			}
		}



	}
}
