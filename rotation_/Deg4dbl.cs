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



namespace nilnul.geometry.planar.rotation_
{
		/// <summary>
		/// another way to express rotation.
		/// </summary>
	public class Degree4dbl : Rotation4dbl
	{

		public const char Symbol = '°';
		


		public Degree4dbl(double val):base(val, _rotation.unit_.Deg4dbl.Singleton)
		{
		}
	


		

		static public Degree4dbl CreateZero() {
			return new Degree4dbl(0);
		}

		static public Degree4dbl Create30() {
			return new Degree4dbl(30);
		}

		static public Degree4dbl Create15() {
			return new Degree4dbl(15);
		}
		static public Degree4dbl Create45() {
			return new Degree4dbl(45);
		}
		static public Degree4dbl Create60() {
			return new Degree4dbl(60);
		}


		static public float ToRadian(float degree) {
			return degree / 180 * (float)Math.PI;
		}
		static public double ToRadian(double degree) {
			return degree / 180 * Math.PI;
		}


		static public Degree4dbl Of(
			RotationOfDoubleI radian4Dbl
		) {
			return new Degree4dbl(
				FroRadian(
					linear_._measured.mark.ExtensionsX.ToStd(radian4Dbl)
					//radian4Dbl.quantity * radian4Dbl.unit.magnitude.dblen.ee
				)
			);
		}

		static public Degree4dbl Of(
			rotation_.Radian4dbl radian4Dbl
		) {
			return new Degree4dbl(
				FroRadian(radian4Dbl.quantity)
			);
		}


		static public float FroRadian(float radian) {
			return radian / nilnul.num.real_.tau.Pi.AsFloat *180;
		}
		static public double FroRadian(double radian) {
			return radian / nilnul.num.real_._Tau4dblX.FULL*360;
		}



	}
}
