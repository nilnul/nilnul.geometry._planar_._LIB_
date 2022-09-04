using nilnul.num.real_;
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



namespace nilnul.geometry.planar.lead_
{
	/// <summary>
	/// imaging that we have a cirle or dot, and lines that are tangent with it.
	/// in comparison with Polar, here the rotation is MEANINGFul even radius is zero. So the information carried by rotation is not lost.
	/// The rotation matters  in [0,1)*Round, if r is zero
	/// 
	/// </summary>
	public class Norm
	{
		private NonnegI _radius;
		public NonnegI radius
		{
			get
			{
				return _radius;
				//throw new NotImplementedException();
			}
		}

		private planar.rotation_.Direction _rotation;

		public planar.rotation_.Direction rotation
		{
			get
			{
				return _rotation;
				//throw new NotImplementedException();
			}
		}

		public Norm(nilnul.num.real_.Nonneg radius, planar.rotation_.Direction rotation)
		{
			_radius = radius;

			_rotation = rotation;


		}

		
	}

}
