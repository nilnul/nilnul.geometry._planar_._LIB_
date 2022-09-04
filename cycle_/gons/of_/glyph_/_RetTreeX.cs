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
	static public class _RetTreeX
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
loop_.gon.co_.nonjoint.be_.torus_._Seige4dblX._Be_assumeNonjoint
			);

			glyph_._RetCyclesX.Cycles(
				c,
				font
			).Each(c=>partitions.add(c) );

	

			return partitions;


		}

		static public nilnul.rel_.net_._taxonomy.ForestBuilder<

planar.cycle_.Polygon4dblI
			> Nesteds(
			IEnumerable< planar.cycle_.Polygon4dblI> cycles
		) {

			var partitions = new nilnul.rel_.net_._taxonomy.ForestBuilder<
				
planar.cycle_.Polygon4dblI
			>(
				//(x,y) =>
cycle_.gon.co_.nonjoint.be_.torus_._Seige4dblX._Be_assumeNonjoint
			);


			foreach (var item in cycles)
			{
				partitions.add(item);

			}

			return partitions;

		}


	}
}
