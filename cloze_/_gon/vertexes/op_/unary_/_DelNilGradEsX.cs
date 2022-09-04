using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_._gon.vertexes.op_.unary_
{
	static public class _DelNilGradEsX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertexes">as this is assumed cloze, thus there at least one point</param>
		/// <returns>
		/// empty if all points are the same.
		/// nonempty if any two points are distinct.
		/// </returns>
		static public List<Point4dblI> _DelNilGradEs_assumeCloze(this IEnumerable<Point4dblI> vertexes) {
			var adacencyProcessed = point.str.op_.unary_._DelNilGradEsX.DelNilGradEs(vertexes).ToList();

			//if (adacencyProcessed.Count==0)
			//{
			//	return adacencyProcessed;
			//}

			var lastIndex = adacencyProcessed.Count - 1;
			if (
				nilnul.geometry.planar.point.EqDbl.Singleton.Equals(
					
					adacencyProcessed[lastIndex]
					,
					adacencyProcessed[0]
				)
			)
			{
				adacencyProcessed.RemoveAt(
					lastIndex
				);

			}
			return adacencyProcessed;

		}


	}
}
