using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.coil_.gon.to_
{

	static public class _Coils4dblX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertexes">
		/// assume conduits means that the incident edges are all <see cref="coil_.gon.skid.co.be_.Cut"/>, or for incident edges, there are two and only two, and the two must be opposite.
		/// </param>
		/// <returns>
		/// cuts are removed. other such as:
		///		cross skids,
		///		or
		///		incident partially(or not fully)
		///
		/// disjoint coils
		/// </returns>
		static public List<List<planar.Grad4dbl_byPointsI>> _Coils_assumeConduit(
			Point4dblI[] vertexes
		)
		{
			var grads = planar.cloze_.gon._Grads4dblX._Grads_ofStarted(
				vertexes
			).ToArray();

			var listOfGrads=new List<planar.Grad4dbl_byPointsI>();

			var coils =new List<List<planar.Grad4dbl_byPointsI>>();

			for (int i = 0; i < grads.Length; i++)
			{
				var index = listOfGrads.FindIndex(
					g=> planar.grad.re_.Opposite4dbl.Singleton.re(g,grads[i])
				);

				if (index <0)
				{
					listOfGrads.Add(grads[i]);
				}
				else				
				{
					// we need to cut the list
					var firstList = listOfGrads.GetRange(0, index );
					var secondList = listOfGrads.GetRange(index+1, listOfGrads.Count - index);

					//cycles.Add(firstList);
					coils.Add(secondList);

					listOfGrads=(firstList);
				}
			}
			if (listOfGrads.Any())
			{
				coils.Add(listOfGrads);

			}

			return coils;


		}


	}
}