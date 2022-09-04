using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;



namespace nilnul.geometry.planar
{
	/// <summary>
	/// on complex plan, multiply z  by e iθ  eiθ rotates  by the angle θ. while ze^(iθ) = z (cos(θ) + i sin(θ) ). so, the θ will go in line with the positive direction of y-axis. 
	/// If y points to upper, the positive goes anti-clockwise. if y points downwards, the postive angle goes to clockwies.
	/// Rotation is measured by "radian"
	/// We'll reserve azimuth for "3d" use.
	/// </summary>
	/// 
	[Obsolete()]
	public interface RotationI
	{
		R radian { get; }
	}

	public class Rotation:RotationI
	{

		private R _radian;

		public R radian
		{
			get { return _radian; }
			set { _radian = value; }
		}

		public Rotation(R radian)
		{
			_radian = radian;

		}

		static public Rotation CreateZero() {
			return new Rotation(
				R.CreateZero()	
			);
		}
	}
}
