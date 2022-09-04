using nilnul.geometry.planar._rotation;
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
	///	Alias:
	///		rounds
	///		turns
	///			sounds like Tau, the 2Pi
	///		circle
	/// </remarks>
	///
	//[Obsolete(nameof(Dir) + ", this shall be used as a measure")]
	public class Rounds4dbl : geometry.planar.Rotation4dbl
	{
		public Rounds4dbl(double quantity0) : base(

			quantity0
			,
			geometry.planar._rotation.unit_.Turn4dbl.Singleton
			)
		{
		}



		static public double _OfRadian(
			double rotationOfDouble
		) {
			return  
					rotationOfDouble / nilnul.num.real_._Tau4dblX.FULL
				
			;
		}

		static public Rounds4dbl OfRadian(
			double rotationOfDouble
		) {
			return  new Rounds4dbl(
					_OfRadian(
						rotationOfDouble
					)
				)
			;
		}
		static public Rounds4dbl Of(
			geometry.planar.RotationOfDoubleI rotationOfDouble
		) {
			return rotationOfDouble switch {
				Rounds4dbl a => a
				,
				_=> OfRadian(
					rotationOfDouble.quantity * rotationOfDouble.unit.magnitude.dblen
				)
			};
		}

		static public Rounds4dbl CreateOneTurn() {
			return new Rounds4dbl(1);
		}
	}
}
