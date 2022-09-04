using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.s.headed
{
	static public class ConnectorsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="headedPoints"></param>
		/// <returns></returns>
		/// <remarks>see: Eval_byMod</remarks>
		static public IEnumerable<Duo> Connectors_byPickLast(this b.Headed.Asserted headedPoints) {

			for (int i = 0; i < headedPoints.val.Count()-1; i++)
			{
				yield return new point.Duo(
					headedPoints.val.ElementAt(i), headedPoints.val.ElementAt(i+1)
				);
			}

			yield return new Duo( headedPoints.val.Last(), headedPoints.val.First() );
		}

		static public IEnumerable<Duo> Connectors(this b.Headed.Asserted headedPoints) {
			var count = headedPoints.val.Count();

			for (int i = 0, j=1; i < count; i++,j++)
			{
				yield return new point.Duo(
					headedPoints.val.ElementAt(i), headedPoints.val.ElementAt(j%count)
				);
			}

		}


	}
}