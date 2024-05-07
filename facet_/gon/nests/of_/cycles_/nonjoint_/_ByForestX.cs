using nilnul.obj.str;
using nilnul.rel_.net_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.gon.nests.of_.cycles_.nonjoint_
{
	static public class _ByForestX
	{

		/// <summary>
		/// of glyph
		/// </summary>
		/// <param name="c"></param>
		/// <param name="font"></param>
		/// <returns></returns>

		static public IEnumerable<Nest> Nesteds(
			char c
			,
			Font font
		) {
			
			return cycle_.gons.of_.glyph_._RetTreeX.CyclesAsTrees(c,font).Select(p=> Nest.Of(p) );


		}



	}
}
