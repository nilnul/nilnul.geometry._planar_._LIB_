using nilnul.num_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_
{
	/// <summary>
	/// eg:
	///		mm
	///		cm^-1
	///		cm^0
	///		mm^3
	///		m^-5
	/// </summary>
	/// alias:
	///		unitan
	///		metric
	public class OfUnit
		:
		nilnul.num.real.expr_.algebraic._frac.Pow
	{
		public geometry.linear_._measured.UnitI unit {
			get {
				return ( (num.real.expr_.var_.geometry_.linear_.Unit)(base.basis ) ).unit;
			}
		}
		public OfUnit(num.real.expr_.var_.geometry_.linear_.Unit val) : base(val)
		{
		}

		public OfUnit(geometry.linear_._measured.UnitI val)
			: this(var_.geometry_.linear_.Unit.Of(val))
		{
		}


		private OfUnit(num.real.expr_.var_.geometry_.linear_.Unit val, BigInteger index)
			: base(val, index)
		{
		}

		public OfUnit(geometry.linear_._measured.UnitI val, BigInteger index) : this(
			var_.geometry_.linear_.Unit.Of(val)
			,
			index
		)
		{
		}


		private OfUnit(num.real.expr_.var_.geometry_.linear_.Unit val, Positive1 index) : base(val, index)
		{
		}
		public OfUnit(geometry.linear_._measured.UnitI val, Positive1 index) : this(
			var_.geometry_.linear_.Unit.Of(val)
			,
			index
		)
		{
		}

		private OfUnit(num.real.expr_.var_.geometry_.linear_.Unit val, int v) : base(val, v)
		{
		}
		public OfUnit(geometry.linear_._measured.UnitI val, int index) : this(
			var_.geometry_.linear_.Unit.Of(val)
			,
			index
		)
		{
		}

		static public OfUnit IndicNil(geometry.linear_._measured.UnitI val) 
		{
			return new OfUnit(val,0);
		}


		/// <summary>
		/// eg:
		///		  mm^2 
		///		=  (0.1 cm)^2 
		///		=.01 cm^2
		/// </summary>
		/// <returns></returns>
		public unitan.Ampled toAmpled(
			geometry.linear_._measured.UnitI unit

			//var_.geometry_.linear_.UnitI unit
		)
		{
			if (unit == this.basis)
			{
				return new unitan.Ampled( this );
			}

			var unitConverted = var_.geometry_.linear_.Unit.ToDeviation(
					this.unit, unit
				);

			return new unitan.Ampled(
				nilnul.num.real_.positive.op_.unary_._IndexX.RetRealI(
					unitConverted.quantity, this.index
				)
				,
				unit
			);


		}
	}
}
