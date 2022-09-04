using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.cloze_.circ
{
	/// <summary>
	/// a bounding box, which might be rotated, a start angle and a sweep rotation.
	/// </summary>
	public class ArcByBounding4Dbl:IArc
	{

		private geometry.planar.tope_.bloc_.Square4dbl _bounding;

		public geometry.planar.tope_.bloc_.Square4dbl bounding
		{
			get { return _bounding; }
			set { _bounding = value; }
		}

		private geometry.planar.rotation.co.sweep_.Simple _swerve;

		public geometry.planar.rotation.co.sweep_.Simple swerve
		{
			get { return _swerve; }
			set { _swerve = value; }
		}


		public ArcByBounding4Dbl(
geometry.planar.tope_.bloc_.Square4dbl bounding0
			,

geometry.planar.rotation.co.sweep_.Simple swerve0
		)
		{
			this._bounding = bounding0;
			this._swerve = swerve0;
		}


		public ArcByBounding4Dbl(
geometry.planar.tope_.bloc_.Square4dbl bounding0
			,

double start, double sweep
		):this(
			bounding0,new geometry.planar.rotation.co.sweep_.Simple(start,sweep)
		)
		{
			
		}

		static public ArcByBounding4Dbl OfStartEnd(
			geometry.planar.tope_.bloc_.Square4dbl bounding0
			,

double start, double end) {
			return new ArcByBounding4Dbl(
				bounding0, start, end - start
			);
		}

	}
}
