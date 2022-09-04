using nilnul.geometry.linear_._measured;
using nilnul.num;
using nilnul.num.real_;
using System;

namespace nilnul.geometry.linear_._measured
{
	
	[Obsolete()]
	public interface Unit4dblI :
		IUnit
		,
		nilnul.obj._measure.Unit4dblI
	{


	}

	[Obsolete()]
	public abstract class Unit4dblA :
		nilnul.obj._measure.Unit4dblA
		,
		Unit4dblI
	{

		protected Unit4dblA(nilnul.num.real_.PositiveDblI val) : base(val)
		{
		}

		public Unit4dblA(double x) : base((x))
		{

		}


		

	}

	/// <summary>
	/// meter
	/// </summary>
	/// <remarks>
	/// alias:
	///	translation:
	///			公尺
	/// </remarks>
	[Obsolete()]
	public class Unit4dbl :
		nilnul.obj._measure.Unit4dbl,

		 Unit4dblI
	{


		public override string ToString()
		{
			return "m";
		}

		static public Unit4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unit4dbl>.Instance;
			}
		}


		

	}





}
