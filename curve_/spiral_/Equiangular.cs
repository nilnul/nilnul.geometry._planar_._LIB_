using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.spiral_
{
	/// <summary>
	/// A logarithmic spiral, equiangular spiral, or growth spiral is a self-similar spiral curve that often appears in nature.
	/// </summary>
	public class Equiangular
		:
		nilnul.obj.Box1<
			nilnul.num.real_.NonnegOfDoubleI
		>
	{
		private double _rotationAmplifier;

		public double rotationAmplifier
		{
			get { return _rotationAmplifier; }
			set { _rotationAmplifier = value; }
		}

		public Equiangular(NonnegOfDoubleI val, double k) : base(val)
		{
			this._rotationAmplifier = k;
		}

		public double radiusAsDblNonneg(double rotation) {

			return boxed.realee.ee * Math.Exp(
				this._rotationAmplifier* rotation
			);

		}
	}
}
