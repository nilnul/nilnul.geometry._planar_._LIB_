using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = System.Numerics.Complex;
using P = nilnul.geometry.planar.Point4dblI;


namespace nilnul.geometry.planar.curl_.elbow
{
	/// <summary>
	/// the direction [0,tau). the base ray is the extending ray of upper arm; the moving ray is the lower arm. When the elbow is straight, direction is 0. When the elbow is folded, direction is pi. the lower arm can rotate passing|crossing|flyingOver the upper arm.
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	/// let the elbow be the origin, let the upperArm be the xAxis pointing to shoulder, let foreArm be the rotating vector.
	/// when y points upward, raise left forearm such that hand is above the arm.
	/// when y points downward (eg: on screen, the edge of gon goes prowind), let down the right forearm such that hand is beneath the arm; now the shoulder is the x's maxward, the arm is folded to shoulder, at rotation 0, then flex, and reflex towards Tau. Note, when it is bigger, it closely prowinds and the area becomes less.
	///
	/// 
	/// <see cref="curl_.elbow._SwingX"/>
	/// <see cref="grad_.skid.co_.angular._DirectionX"/>
	/// alias:
	///		thrash
	static public class _DirectionX
	{

		static public double _Direction_012elbow(
			C start,C pivot, C end
		) {
			return 	vect_.nonnil.co._RotationX._Direction_01nonnil(
				pivot-start		/// shift the grad:ab such as to be based at b.
								/// b is the pivot, as the origin. from elbow to should as the real axis growing from elbow to shoulder
				,
				end -pivot
			);
		}
		static public double _Direction_012elbow(
			P start, P hinge,P end
		) {
			return _Direction_012elbow(
				start.ToComplex(),hinge.ToComplex(),end.ToComplex()
			);
		}

		public static double _Direction_1final(Grad4dbl_byPointsI skid1st, P final)
		{
			return _Direction_012elbow(skid1st.basis,skid1st.finish,final);
		}
	}
}
