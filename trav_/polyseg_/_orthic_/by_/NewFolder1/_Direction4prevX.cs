using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.trav_.polyseg_._orthic_.by_
{
	static public class _Direction4prevX
	{
		static public IEnumerable<Complex> Points(
			IEnumerable<double> steps
		) {

			var lastP = new Complex();

			yield return lastP;

			var quarter = new Complex(0,1);
			var negQuarter = new Complex(0,-1);


			var directionAsComplex = negQuarter;
			foreach (var item in steps)
			{
				if (item==0)
				{
					yield return lastP;
				}
				else
				{
					if (item>0)
					{
						directionAsComplex *= quarter; // current Direction;
						lastP += item * directionAsComplex;

						yield return lastP;

					}
					else {
						directionAsComplex *= negQuarter; // current Direction;
						lastP -= item * directionAsComplex;

						yield return lastP;

					}
		

				}
			}
		}

	

	}
}
