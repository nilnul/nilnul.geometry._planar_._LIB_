using nilnul.geometry.planar._ray_;
using nilnul.geometry.planar.point;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.angle_
{

	/// <summary>
	/// 'cuz point is basic object in geometry.planar, so everything is preferably defined using points.
	/// the rotation can be interpreted as negative or positive, so we may defer the definition of rotation to an extension method in an extension class.
	/// 
	/// We may prefer the negative, as it can indicate how light is reflected: if the inward light, with reference to the downward norm, shines down to the left and then onto the level mirror, the outward reflected light will travel left; if the inward light shines down to the right to the norm, the light will travel to the right; if the inward light shines down straint, the angle is zero. So we can tell by the sign of the angle of how inward light shines with reference to norm
	/// This also partially reflects the meaning of reflection: you have both positive and negative, symmetry with respect to nil.
	/// </summary>
	///
	[Obsolete(nameof(angle_.ByPoints),true)]
	public class Reflection : geometry.planar.point.trio.be_.steps.vow.Ee
		,
		planar.IAngle
	{
		public Reflection(point.Trio val) : base(val)
		{
		}

		public Reflection(Point1 inward, Point1 pivot, Point1 outward) : base(inward, pivot, outward)
		{
		}

		

		public RayI initial => new planar.ray_.OnArrow(
			ee.a, ee.b
		);

		/// <summary>
		/// note that this is the distortion of the inward light's extention.
		/// if the light travels straight on, the return value is nil
		/// if the light is refracted, the returned value is acute.
		/// if the light is reflected, the returned value is astuse
		///
		/// if the light turns left, the returned value is positibve, in align with the positiveness of anti-clockwise direction
		/// 
		/// </summary>
		/// <remarks></remarks>
		/// <returns>
		/// (-tau,tau)
		/// </returns>
		public nilnul.geometry.planar.RotationI1 azimuth => nilnul.geometry.planar.grad_.skid._DirectionX._Direction_assumeDif(ee.a, ee.c)

			-
			nilnul.geometry.planar.grad_.skid._DirectionX._Direction_assumeDif(ee.a, ee.b)
		;   //this value is not normalized. in (-tau, tau) need to be normalized. when normalized, positive means turn left|positive; negative means turn right; PI means turn back; 0 means no turn.
		public planar.rotation_.Direction direction
		{
			get
			{
				var t = azimuth.quantity;
				if (t < 0)
				{
					return new rotation_.Direction(t + nilnul.num.real_.Tau.Singleton.ToReal());
				}

				return new rotation_.Direction(t );


			}
		}

		public nilnul.num.real.be_.geNegPiLtPi.vow.Ee azimuthGeNegPiLtPi {
			get {
				var t = azimuth.quantity;
				if (t>= nilnul.num.real_.TauX.Half)
				{
					return new nilnul.num.real.be_.geNegPiLtPi.vow.Ee(
						  t- nilnul.num.real_.Tau.Singleton.ToReal()
					);	// [pi, tau) -tau =  [-pi, 0)
				}
				//if (t ==nilnul.num.real_.TauX.Half)
				//{
				//	return new nilnul.num.real.be_.geNegPiLtPi.vow.Ee(
				//		-nilnul.num.real_.TauX.Half
				//	);
				//}
				if (t< - nilnul.num.real_.TauX.Half)
				{
					return new nilnul.num.real.be_.geNegPiLtPi.vow.Ee(
						nilnul.num.real_.Tau.Singleton.ToReal() + t
					);	// (-tau, --pi) +tau= (0, pi)
				}

				return new nilnul.num.real.be_.geNegPiLtPi.vow.Ee(t);		//
				// 
			}
		}

		public nilnul.num.real.be_.gtNegPiLePi.vow.Ee azimuthGtNegPiLePi {
			get {
				var t = azimuth.quantity;
				if (t> nilnul.num.real_.TauX.Half)
				{
					return new nilnul.num.real.be_.gtNegPiLePi.vow.Ee(
						t- nilnul.num.real_.Tau.Singleton.ToReal()
					);  // (pi, tau) -tau =  (-pi, 0)
				}
			
				if (t<= - nilnul.num.real_.TauX.Half)
				{
					return new nilnul.num.real.be_.gtNegPiLePi.vow.Ee(
						nilnul.num.real_.Tau.Singleton.ToReal() + t
					);	//  (-tau, -pi] + tau = (0, pi] 
				}

				return new num.real.be_.gtNegPiLePi.vow.Ee( t);		//
				// 
			}
		}


	}


}
