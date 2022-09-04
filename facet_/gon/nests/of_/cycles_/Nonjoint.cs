using nilnul.obj.str;
using nilnul.rel_.net_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.gon.nesteds.of_.cycles_
{
	static public class _NonjointX
	{
		static public IEnumerable<Nested> Nesteds(
			IEnumerable< planar.cloze_.Polygon4dblI> cycles
		) {
			var partitions = new List<
				List<
planar.cloze_.Polygon4dblI
			>>();


			foreach (var item in cycles)
			{
				var related= partitions.Where(
					p=>
					p.Any(
						c=> cycle_.gon.co_.nonjoint.be_._Torus4dblX._Be_cyclesAssumeNonjoint(c.vertexes, item.vertexes)
					)
				);

				if (related.Any())
				{
					related.Each(
						x=>
						partitions.Remove(x)
					);
				}
				var first = related.First();

				foreach (var item111 in related.Skip(1))
				{
					first.AddRange(item111);

				}

				partitions.Add(first);


			}

			return partitions.Select(n=> Nested.Of(n) );

		}
	}
}
