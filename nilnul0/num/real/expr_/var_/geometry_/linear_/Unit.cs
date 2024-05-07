using nilnul.geometry.linear_._measured;
using System.Collections.Concurrent;
using U = nilnul.geometry.linear_._measured.UnitI;


namespace nilnul.num.real.expr_.var_.geometry_.linear_
{
	public class Unit : Unit<nilnul.geometry.linear_._measured.UnitI>
	{
		static public readonly ConcurrentDictionary<nilnul.geometry.linear_._measured.UnitI, Unit> keyValues = new System.Collections.Concurrent.ConcurrentDictionary<geometry.linear_._measured.UnitI, Unit>();
		private Unit(U unit) : base(unit)
		{
		}

		static public Unit Of(U unit) {
			return keyValues.GetOrAdd(
				unit,
				(u)=>new Unit(u)
			);
		}

		static public implicit operator Unit(nilnul.geometry.linear_._measured.Unit unit)
		{
			return new Unit(unit);
		}
		static public implicit operator Unit(nilnul.geometry.linear_._measured.UnitA unit)
		{
			return new Unit(unit);
		}


		static public unitan.Quantitied ToDeviationByStd(
			geometry.linear_._measured.UnitI src
		)
		{
			return _UnitX.ToDeviationByStd(
				src
			);
		}


		/// <summary>
		/// eg:
		///		  mm^2 
		///		=  (0.1 cm)^2 
		///		=.01 cm^2
		/// </summary>
		/// <returns></returns>
		static public unitan.Quantitied ToDeviation(
			geometry.linear_._measured.UnitI src
			,
			geometry.linear_._measured.UnitI tgt
		)
		{
			return var_.geometry_.linear_._UnitX.ToDeviation(
				src,tgt
			);
		}
	}
}
