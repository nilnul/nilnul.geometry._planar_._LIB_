using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.ray.co.be_
{

	/// <summary>
	/// direction same or opposite
	/// </summary>
	static public  class _AlignDblX
	{
		static public bool Eval_byCompareAngle(Arrow dir, point.PointInDouble start, point.PointInDouble end) {
			return Math.Abs(dir.angle - new _2d.point.binary.be.Irreflexive.Asserted(start, end).angle) < 1;
		}

		static public bool Eval(Arrow dir, point.PointInDouble start, point.PointInDouble end) {

			var dirStart2start = nilnul.geometry._2d.point.pair.Distance.Eval(dir.start, start);

			var dirStart2end = nilnul.geometry._2d.point.pair.Distance.Eval(dir.start, end);
			var dirEnd2start = nilnul.geometry._2d.point.pair.Distance.Eval(dir.end, start);
			var dirEnd2end = nilnul.geometry._2d.point.pair.Distance.Eval(dir.end, end);

			var crossed = dirStart2end + dirEnd2start;

			var sided = dirStart2start + dirEnd2end;
			return crossed > sided;
		}

		static public bool Eval_byCompareAngle(Dir dir, point.PointInDouble start, point.PointInDouble end) { 

			return Math.Abs(dir.angle - new _2d.point.binary.be.Irreflexive.Asserted(start, end).angle) < 1;
		}

		static public bool Eval(Dir dir, point.PointInDouble start, point.PointInDouble end) {

			var dirStart2start = nilnul.geometry._2d.point.pair.Distance.Eval(dir.start, start);

			var dirStart2end = nilnul.geometry._2d.point.pair.Distance.Eval(dir.start, end);
			var dirEnd2start = nilnul.geometry._2d.point.pair.Distance.Eval(dir.end, start);
			var dirEnd2end = nilnul.geometry._2d.point.pair.Distance.Eval(dir.end, end);

			var crossed = dirStart2end + dirEnd2start;

			var sided = dirStart2start + dirEnd2end;
			return crossed > sided;
		}
	}
}
