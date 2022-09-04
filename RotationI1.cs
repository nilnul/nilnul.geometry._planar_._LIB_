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
using RI = nilnul.num.RealI;
using nilnul.num;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// rotation is directional (positive or negative; clockwise or counterclockwise). If we are interested only in its abs value, not direction,  we can use rotation.abs
	/// </summary>
	static public class _RotationX {
		static public double Degree2Radian(this double degree)
		{
			return degree / 360 * num.real_.TauX.IntoDouble;
		}
		static public double Radian2Degree(this double radian)
		{
			return radian / 360 * num.real_.TauX.IntoDouble;
		}

		static public double NormalizeInTau(double radian)
		{

			return radian % TAU;

		}

		public const double TAU = 2 * Math.PI;

		static public double HalfTau = Math.PI;

		static public double HalfPi = Math.PI / 2;

		public static double ThreeQuarter = HalfPi * 3;
	}

	/// <summary>
	/// on complex plan, multiply z  by e iθ  eiθ rotates  by the angle θ. while ze^(iθ) = z (cos(θ) + i sin(θ) ). so, the θ will go in line with the positive direction of y-axis. 
	/// If y points to upper, the positive goes anti-clockwise. if y points downwards, the postive angle goes to clockwies.
	/// Rotation is measured by "radian"
	/// We'll reserve azimuth for "3d" use.
	/// </summary>
	public interface RotationI1
	{
		R quantity { get; }
		_rotation.UnitI unit { get; }
	}

	public class Rotation1:
		//Real   //we here prefer aggregation over inheritance per the suggestion of DesignPatterns

		RotationI1
	{

		private R _radian;

		public R quantity
		{
			get { return _radian; }
			set { _radian = value; }
		}

		public _rotation.UnitI unit => _rotation.Unit.Singleton;

		public Rotation1(R radian)
		{
			_radian = radian;
		}

		public Rotation1(RI real):this(real.ToReal())
		{
		}

		public Rotation1(RotationI1 rotation):this(rotation.quantity * rotation.unit.asRadian)
		{

		}

		static public implicit operator Rotation1(nilnul.num.Real real) {
			return new Rotation1(real);
		}
		static public implicit operator Real(Rotation1 real) {
			return (real).quantity;
		}


		static public Rotation1 CreateZero() {
			return new Rotation1(
				R.CreateZero()	
			);
		}

		static public bool operator ==(Rotation1 a, Rotation1 i) {
			return a.quantity == i.quantity;
		}

		static public bool operator !=(Rotation1 a, Rotation1 i) {
			return !(a == i);
		}

		static public bool operator ==(Rotation1 a, int i) {
			return a == new Rotation1(i);
		}


		static public bool operator !=(Rotation1 a, int i) {
			return !(a == (i) );
		}

		static public bool operator ==( int i, Rotation1 a) {
			return a == (i);
		}


		static public bool operator !=( int i, Rotation1 a) {
			return a != (i) ;
		}


	}
}
