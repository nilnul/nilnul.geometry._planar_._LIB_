using nilnul.obj.str;
using nilnul.rel_.net_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gons.of_.glyph_.retTree_
{
	static public class _LogicEmbedX
	{
		/// <summary>
		/// fillmode is considered
		/// </summary>
		/// <param name="c"></param>
		/// <param name="font"></param>
		/// <returns></returns>
		static public nilnul.rel_.net_._taxonomy.ForestBuilder< planar.cycle_.Polygon4dblI> CyclesAsTrees(
			char c
			,
			Font font
		)
		{
			var partitions = new nilnul.rel_.net_._taxonomy.ForestBuilder<

planar.cycle_.Polygon4dblI
			>(
//(x,y) =>
cycle_.gon.co_.nonjoint.be_.nest_._Seige4dblX._Be_assumeNonjoint
			);

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
				var cycleContainer = new GraphicsPath();

				//var nextPath =
				figs.NextSubpath(cycleContainer, out var isClosed);

				if (isClosed)
				{

					partitions.add(
						new cycle_.Polygon4dbl(
							cycleContainer.PathPoints.Select(
								f => planar.Point4dbl.Of(f)
							)
						)
					);



				}
				else
				{
					throw new Exception("all paths in character shall be closed");

				}

			}

			return partitions;


		}


	}
}
