using nilnul.geometry.linear_._measured.unit.calc.amount_;
using nilnul.geometry.linear_._measured.unit.calc_.indic;
using System.Numerics;

namespace nilnul.geometry.linear_._measured.unit.calc_
{
	public class Indic4dbl
		: nilnul.obj.Box1<_measured.Unit4dblI>
		,
		unit.Calc4dblI
		//,
		//_calc_.Reduce4dblI
	{
		public Indic4dbl(Unit4dblI val, BigInteger indic) : base(val)
		{
			this._indic = indic;
		}

		public Indic4dbl(Unit4dblI val) : this(val, 1)
		{
		}

		

		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		indic
		///			analog to radic
		///		index
		///		indexer
		private BigInteger _indic;

		public BigInteger indic
		{
			get { return _indic; }
			set { _indic = value; }
		}

		public Unit4dblI radic { get { return boxed; } }

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// a**-1
		/// a^-1
		/// 
		/// </returns>
		public override string ToString()
		{
			return $"{boxed}**{_indic}";
		}

		public Reduced4dbl reduce()
		{
			return new Reduced4dbl(this);
		}

		public Prod4dbl toIndics()
		{
			return new Prod4dbl(new[] { this });
		}
	}
}
