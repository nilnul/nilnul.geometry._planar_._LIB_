using nilnul.obj.str;
using nilnul.rel_.net_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gons.of_.glyph_
{
	static public class _RetCyclesX
	{

		/// <summary>
		/// the fillmode info is lost. But it seems the winding direction is correct per the font.
		/// </summary>
		/// <param name="c"></param>
		/// <param name="font"></param>
		/// <returns></returns>
		/// note: character 6 seems has an ending which is the same as the begining.
		static public List<planar.cycle_.Polygon4dbl> Cycles(
			char c
			,
			Font font
		)
		{
			return cloze_.gons.of_.glyph_._RetClozesX.Clozes(c,font).Select(
				c=>cycle_.Polygon4dbl.Of(c)
			).ToList();
		}
	}
}
