using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.co
{
	public interface BeI
		:nilnul.obj.BeI1<line.Co>
	{
	}

	public abstract class BeA :
		nilnul.obj.co.BeA<planar.LineI, planar.line.Co>
		,
		BeI
		,
		nilnul.obj.co._be_.OfSpreadI<planar.Line>

	{
		public bool be(Line a, Line b)
		{
			return be((LineI)a, (LineI)b);
		}
		
	}

	public abstract class BeOnReA :
		nilnul.obj.co.BeOnReA<planar.LineI, planar.line.Co>
		,
		BeI

	{
		
		
	}

}
