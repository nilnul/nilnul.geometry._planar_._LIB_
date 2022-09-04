using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point.co.be_;

namespace nilnul.geometry.planar.line_
{
	/// <summary>
	/// defined by a step
	/// </summary>
	public class Peg
		: nilnul.obj.Box<point.duo.be_.dif.En>
	{
		private point.duo.be_.dif.En _points;

		public point.duo.be_.dif.En points
		{
			get { return _points; }
			set { _points = value; }
		}

		public Peg(point.duo.be_.dif.En val) : base(val)
		{
		}

	
	}
}
