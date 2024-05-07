using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.var_.geometry_.linear_
{
	public class Unit<T>
		:
		nilnul.num.real.expr_.Var1
		,
		UnitI
		where T : nilnul.geometry.linear_._measured.UnitI
	{
		private T _unit;

		public T unit
		{
			get { return _unit; }
			set { _unit = value; }
		}

		public Unit(T unit) : base(unit.ToString())
		{
			this._unit = unit;
		}

		public unitan.Quantitied toDeviationByStd(
		)
		{
			return new unitan.Quantitied(
				unit.magnitude
				,
				geometry.linear_._measured.Unit.Singleton
			);
		}



		/// <summary>
		/// eg:
		///		  mm^2 
		///		=  (0.1 cm)^2 
		///		=.01 cm^2
		/// </summary>
		/// <returns></returns>
		public unitan.Quantitied toDeviation(
			geometry.linear_._measured.UnitI unit
		//var_.geometry_.linear_.UnitI unit
		)
		{
			if (object.ReferenceEquals(unit, this.unit))
			{
				return new unitan.Quantitied(unit);
			}

			/// eg: this is mm, and par is cm
			///		we have:
			///			mm= 1/1000 m
			///			cm =1/100 m
			///			then, divide the two equation
			///			mm /cm = 1/1000 / (1/100)
			///		then
			///				mm= (1/1000 / (1/100)) cm
			///					= 0.1cm
			///
			/// note here even if two unit with same magnitude are named differently, we will still get the correct result as long as the real dividion works out;
			return new unitan.Quantitied(
				this.unit.magnitude.real.en.ToReal()
				/

				unit.magnitude
				,
				unit
			);
		}

	}
}