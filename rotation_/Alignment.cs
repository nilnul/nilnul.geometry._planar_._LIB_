using nilnul.num;
using nilnul.num.real_.nonneg_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;


namespace nilnul.geometry.planar.rotation_
{
	/// <summary>
	/// a rotation in [0,pi). measure the angle of a line with respect to the line on xAxis.
	/// </summary>
	/// <remarks>
	/// <see cref="rotation_.nonneg_.LtPi"/>
	/// </remarks>
	/// alias:
	///		alignment
	///		sweep
	public class Alignment :
		planar.rotation_.nonneg_.LtPi


	{
		public Alignment(LtPi val) : base(val)
		{
		}

		public Alignment(Direction direction):this(new LtPi( direction))
		{
		}

		public Alignment(Real real):this(new LtPi(real))
		{
		}
		static public bool operator ==(Alignment a, Alignment b) {
			return a.ToReal() == b.ToReal();
		}
		static public bool operator !=(Alignment a, Alignment b) {
			return ! (a == b);
		}

	}
}
