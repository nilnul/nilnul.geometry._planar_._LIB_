using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = System.Numerics.Complex;
using P = nilnul.geometry.planar.Point4dblI;


namespace nilnul.geometry.planar.curl_.elbow.swing_
{
	/// <summary>
	/// for unfurl|elbow a,b,c,  now extend ab as a`b`, where a` is b, b` = a`+(b-a).  then c-b rotates relative to a`b`, the extended ray of ab,  from -Pi, to Pi, that is: (-pi, pi].
	/// </summary>
	/// <remarks>
	/// it's like a door, it can be opened, reflexively, when rotation is greater than -pi, and it can be closed when it is Pi.
	/// 
	/// </remarks>
	/// 
	///
	/// <see cref="grad_.skid.co_.angular._DirectionX"/>
	/// alias:
	///		wind
	///			,	used in gon surrounding, the more swing, the more constricted it is;
	///		
	static public class _OpenCloseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="initial"></param>
		/// <param name="pivot">
		/// not initial.
		/// </param>
		/// <param name="tip">non pivot; might be same as <paramref name="initial"/></param>
		/// <returns></returns>
		static public double _Swing_12elbow(
			C initial, C pivot,C tip
		) {
			var d= 	vect_.nonnil.co._RotationX._Direction_01nonnil(
				pivot-initial  /// shift the grad:ab such as to be based at b.
				,
				tip-pivot
			);

			if (d>Math.PI)
			{
				return d - num.real_.eg_._Tau4dblX.FULL;
			}
			return d;
		}
		static public double _Swing_12elbow(
			P a, P b,P c
		) {
			return _Swing_12elbow(
				a.ToComplex(),b.ToComplex(),c.ToComplex()
			);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="skid1st"></param>
		/// <param name="final">
		/// not same as the target point of <paramref name="skid1st"/>
		/// </param>
		/// <returns></returns>
		public static double _Swing_0skid_1final(Grad4dbl_byPointsI skid1st, P final)
		{
			return _Swing_12elbow(skid1st.basis, skid1st.finish, final);
		}

	}
}
