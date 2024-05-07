using System;
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
		/// coil_.gon
		/// </param>
		/// <returns></returns>
		/// <see cref="nilnul.geometry.planar.coil_.gon_.conduit.to_._Cycles4dblX"/>
		static public List<List<planar.Grad4dbl_byPointsI>> _CoilsByRemoveDuct_0coil(
			IEnumerable<Point4dblI> vertexes
		)
		{

			var grads = planar.cloze_.gon._Grads4dblX._Grads_ofStarted(
				vertexes
			).ToArray();

			var listOfGrads = new List<planar.Grad4dbl_byPointsI>();

			var coils = new List<List<planar.Grad4dbl_byPointsI>>();

			for (int i = 0; i < grads.Length; i++)
			{
				var index = listOfGrads.FindIndex(
					g => planar.grad.re_.Opposite4dbl.Singleton.re(g, grads[i])
				);

				if (index < 0)
				{
					listOfGrads.Add(grads[i]);
				}
				else
				{
					// we need to cut the list
					var firstList = listOfGrads.GetRange(0, index);
					
					var secondList = listOfGrads.GetRange(++index, listOfGrads.Count - index);  /// for outgoing edges from same pivot, the rotation order is not preserved, as FindIndex finds the first, not the minimal.

					//cycles.Add(firstList);
					coils.Add(secondList);

					listOfGrads = (firstList);
				}
			}
			if (listOfGrads.Any())
			{
				coils.Add( listOfGrads); 
				//coils.Insert(0, listOfGrads); /// not add, such that the hull is placed ahead.

			}

			return coils;
		}


		static public List<List<planar.Grad4dbl_byPointsI>> _CoilsByRemoveDuct_0coil(
			Point4dblI[] vertexes
		)
		{
			return _CoilsByRemoveDuct_0coil(
				(IEnumerable<Point4dblI>) vertexes
			);

		}

		//[Obsolete(nameof(_Coils_removeConduit))]
		//static public List<List<planar.Grad4dbl_byPointsI>> _Coils_removeConduit(
		//		Point4dblI[] vertexes
		//	)
		//{
		//	return _Coils_removeConduit(vertexes);
		//}
	}
}