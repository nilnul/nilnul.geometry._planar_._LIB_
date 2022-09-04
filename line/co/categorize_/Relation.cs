using nilnul.geometry.planar;
using nilnul.geometry.planar.line.co.categorize_._positional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.line.co.categorize_
{
	/// <summary>
	/// positional relation of two lines:
	///		crossed,
	///		align
	/// </summary>
	static public  class _PositionalX
	{
		static public Rel Positional(Line x, Line y) {

			if (planar.line.co.be_.Fork.Singleton.re(x,y))
			{
				return Rel.Interset;
			}
			
			

			if (
				planar.line.be_.HasPointX.Bit(x, y.begin)
			)
			{
				return Rel.Same;
			}
			return Rel.Parallel;
			
		}

		
		

	}
}
