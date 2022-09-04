using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.direction.co
{
	public class Swerve
	{

		geometry.planar.rotation_.DirectionDbl _start;
		public geometry.planar.rotation_.DirectionDbl start
		{
			get { return _start; }
			set { _start = value; }
		}


		geometry.planar.rotation_.DirectionDbl _sweep;

		public geometry.planar.rotation_.DirectionDbl sweep
		{
			get { return _sweep; }
			set { _sweep = value; }
		}
		public Swerve(
			geometry.planar.rotation_.DirectionDbl _start
			,
			geometry.planar.rotation_.DirectionDbl sweep0

		)
		{
			this._start = _start;
			this._sweep = sweep0;

		}

		public Swerve(double start1, double sweep1)
			:this(
				  DirectionDbl.Create_byCannonize(start1)
				 ,
				  DirectionDbl.Create_byCannonize(sweep1)
			)
		{
		}
	}
}
