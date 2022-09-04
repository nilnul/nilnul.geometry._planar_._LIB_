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
	/// a rotation in [0,pi)
	/// </summary>
	/// alias:
	///		alignment
	///		sweep
	///
	[Obsolete(nameof(Alignment) + "; also orient is used for axises orientation such as left handed, right handed, etc")]
	public class Orientation :
		planar.rotation_.nonneg_.LtPi


	{
		public Orientation(LtPi val) : base(val)
		{
		}

		public Orientation(Direction direction):this(new LtPi( direction))
		{
		}

		public Orientation(Real real):this(new LtPi(real))
		{
		}
		static public bool operator ==(Orientation a, Orientation b) {
			return a.ToReal() == b.ToReal();
		}
		static public bool operator !=(Orientation a, Orientation b) {
			return ! (a == b);
		}

	}
}
