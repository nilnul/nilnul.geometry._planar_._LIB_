using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_
{
	public interface SeqI
		: nilnul.obj.str_.SeqI2<planar.PointI1>
		,
		planar.point.StrI

	{

	}
	public class Seq
		: nilnul.obj.str_.Seq2<planar.PointI1>
		,
		planar.point.StrI
		,SeqI
	{
		public Seq(IEnumerable<Point1> boxed) : base(boxed)
		{
		}

		public Seq(IEnumerable<PointI1> enumerable):base(enumerable)
		{
		}
	}
}
