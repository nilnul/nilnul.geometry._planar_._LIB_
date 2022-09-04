using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P1 = nilnul.geometry.planar.point.CoD;

namespace nilnul.geometry.planar
{

	public interface IRayDbl : _ray_.ISrcD, _ray_.IRotationD
	{

	}
	/// <summary>
	/// ray defined by two points
	/// </summary>
	/// 

	public  class RayDbl
		:IRayDbl
	{

		private Point4dblI _src;
		public Point4dblI src => _src;

		private double _rotation;

		public double rotation => _rotation;

		public RayDbl(Point4dbl src, double rotation)
		{
			_src = src;
			_rotation = rotation;
		}

		public void cannonize()
		{
			_rotation = planar.rotation_.DirectionDbl.Create_byCannonize(_rotation);
		}
	}
}
