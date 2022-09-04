using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.zone_.polygon_.monogon_
{
	public  class Monogon
	{
		private PointI1 _point;

		public PointI1 point
		{
			get { return _point; }
			set { _point = value; }
		}
		
		public Monogon(PointI1 point)
		{
			_point = point;

		}
	}
}
