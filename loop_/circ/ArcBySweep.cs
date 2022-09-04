using nilnul.geometry.planar.curve_.cloze_.circ_;
using nilnul.geometry.planar.loop_.circ_;
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
	public class ArcBySweep4Dbl :
		nilnul.obj.Box1<
			nilnul.geometry.planar.loop_.circ_.Nontrivia4dbl
		>
		,
		IArc
	{
		private geometry.planar.rotation.co.sweep_.Simple _sweep;

		public geometry.planar.rotation.co.sweep_.Simple sweep
		{
			get { return _sweep; }
			set { _sweep = value; }
		}
		public ArcBySweep4Dbl(
			Nontrivia4dbl val
			,
			geometry.planar.rotation.co.sweep_.Simple swerve0

		) : base(val)
		{

			this._sweep = swerve0;

		}

		public ArcBySweep4Dbl(
			Nontrivia4dbl val
			,
			double start
			,
			double sweep
		) : this(
			val, new geometry.planar.rotation.co.sweep_.Simple(start, sweep)
		)
		{

		}

		public double length()
		{
			return boxed.circumference()
			*
			nilnul.geometry.planar.rotation_.Rounds4dbl.Of(
				this._sweep.change
			).quantity
			;
		}

		public double radius { get { return boxed.radius; } }
		public Point4dbl center { get { return boxed.center; } }

		static public ArcBySweep4Dbl OfStartEnd(
			Nontrivia4dbl bounding0
			,

double start, double end)
		{
			return new ArcBySweep4Dbl(
				bounding0, start, end - start
			);
		}

	}
}
