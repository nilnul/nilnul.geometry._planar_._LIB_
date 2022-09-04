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
	/// in the unit of turn
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(Rounds4dbl)"/>
	///	Alias:
	///		rounds
	///		turns
	///			sounds like Tau, the 2Pi
	///		circle
	/// </remarks>
	///
	//[Obsolete(nameof(Dir) + ", this shall be used as a measure")]

	public class Turns
	{
		/// <summary>
		/// quadrant one
		/// </summary>
		public const double Quarter = Math.PI / 2;
		public const double Half = Math.PI;
		public const double ThreeQuarter = Math.PI + Quarter;

		public const double Tau = Math.PI * 2;
		/// <summary>
		/// one round
		/// </summary>
		public const double Full = Math.PI * 2;

		private R _val;

		public Turns(R val)
		{
			nilnul.num.real.be_.nonneg.Vow.Singleton.vow(val);

			nilnul.obj.aver_.True.Aver(

			nilnul.num.real.co.be_.Lt.Lazy.be(val, new nilnul.num.real_.Tau())
			);
			_val = val;
		}

		static public Turns operator -(Turns x, Turns y) {
			var t = nilnul.num.real.op_.binary_.Minus.Singleton.op( x._val, y._val);

			if (nilnul.num.real.be_.Negative.Singleton.be(t))
			{
				t = nilnul.num.real.op_.binary_.Add.Singleton.op(t, new nilnul.num.real_.Tau());
			}
			return new Turns(

					t
				);

		}

		public bool gtPi() {
			return nilnul.num.real.re_.Gt.Lazy.re(_val, nilnul.num.real.op_.unary_._ScaleX.Scale( new Q1(1, 2), new nilnul.num.real_.Tau())
			);
		}

		public bool ltPi() {
			return nilnul.num.real.re_.Lt.Lazy.re(_val, nilnul.num.real.op_.unary_._ScaleX.Scale( new Q1(1, 2), new nilnul.num.real_.Tau())
			);
		}

		public bool isZero() {
			return nilnul.num.real.be_.Nil.Singleton.be(_val);
		}


	}
}
