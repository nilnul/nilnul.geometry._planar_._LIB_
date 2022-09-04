using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._line_._norm
{
	/// a lead and an azimuth.
	/// <summary>
	/// in comparison with Polar, here the rotation is MEANINGFul even radius is zero. So the information carried by rotation is not lost.
	/// when the radius is nil,  The rotation matters  in [0,.5)*Round
	/// </summary>
	public class Norm
	{

		public Norm(nilnul.num.real_.Nonneg radius, planar.RotationI1 rotation)
		{
			_radius = radius;

			_rotation = rotation;


		}

		/// <summary>
		/// this can be relaxed to including negative values.
		/// </summary>
		private NonnegI _radius;
		public NonnegI radius
		{
			get
			{
				return _radius;
				//throw new NotImplementedException();
			}
		}

		/// <summary>
		/// this defines a <see cref="geometry.planar.lead_.IThruOrigin"/>.
		/// any vector(from origin to a point) would be projected (decomposed) onto that lead, <see cref="nilnul.geometry.planar.vect.to_.co_.decompose._ProjectionX"/>; and the component shall be <see cref="radius"/>, or in other words, the line to be defined would be perpendicular to the lead at the offset of <see cref="radius"/>
		/// </summary>

		private RotationI1 _rotation;

		public RotationI1 rotation
		{
			get
			{
				return _rotation;
				//throw new NotImplementedException();
			}
		}
	}

}
