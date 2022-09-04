using nilnul.obj.str;
using nilnul.rel_.net_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gons.of_.glyph_
{
	static public class _RetClozesX
	{

		/// <summary>
		/// the fillmode info is lost. But it seems the winding direction is correct per the font.
		/// </summary>
		/// <param name="c"></param>
		/// <param name="font"></param>
		/// <returns></returns>
		/// note: character 6 seems has an ending which is the same as the begining.
		static public List<planar.cloze_.Polygon4dblI> Clozes(
			char c
			,
			Font font
		)
		{

			var r = new List<planar.cloze_.Polygon4dblI>();
			GraphicsPath characterPath = new GraphicsPath();
			//var c = 'A';
			//var font = new Font("Times New Roman", 12);

			characterPath.AddString(
				c.ToString(),
				font.FontFamily, (int)font.Style, font.Size, Point.Empty
				,
									StringFormat.GenericTypographic);
			//draw the path

			characterPath.Flatten();

			var figs = new GraphicsPathIterator(characterPath);

			for (int i = 0; i < figs.SubpathCount; i++)
			{
				//var nextType = figs.NextPathType(out var type, out var start, out var end);
				var path11 = new GraphicsPath();

				var nextPath = figs.NextSubpath(path11, out var isClosed);

				if (isClosed)
				{

					r.Add(
						new cloze_.Polygon4dbl(
							path11.PathPoints.Select(
								f => planar.Point4dbl.Of(f)
							)
						)
					);



				}
				else
				{
					throw new Exception("all paths in character shall be closed");

				}

				//if (nextPath == 0)
				//{
				//	break;
				//}


			}
			return r;


		}


	}
}
