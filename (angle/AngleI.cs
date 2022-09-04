using nilnul.geometry.planar._angle_;
using nilnul.geometry.planar._ray_;
using nilnul.geometry.planar.point;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// angle has the inital ray, and a rotation.
	/// The terminal ray can be computated.
	/// angle is a geometric object on the coordinated plane, different from rotation, which is a scalar value
	/// 
	/// </summary>
	public interface IAngle : _angle_.InitialI, _angle_.AzimuthI
	{
	}

	/// <summary>
	/// </summary>
	public class Angle : IAngle
	{
		private RayI _inital;

		public RayI initial
		{
			get => _inital;
			set { _inital = value; }
		}

		private planar.RotationI1 _azimuth;
		public planar.RotationI1 azimuth
		{
			get => _azimuth;
			set => _azimuth = value;
		}

		public Angle(
			RayI initial,
			planar.RotationI1 azimuth
		)
		{
			_inital = initial;
			_azimuth = azimuth;

		}


		public static Angle Ov(Ray dir, Point1 point)
		{
			return new Angle(
				dir,
				new grad_.Arrow(dir.src,point).direction
			);
		}
	}


}
