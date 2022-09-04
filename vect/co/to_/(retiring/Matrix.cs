using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.geometry.planar.vector.co
{
	/// <summary>
	/// a matrix with one vector on the other.
	/// </summary>
	public class Matrix
	{
		static public nilnul.num.real.matrix_.square_.Two_Two Fro(Point a, Point b) {
			return new num.real.matrix_.square_.Two_Two(
				a.x,a.y,b.x,b.y	
			);

		}
		static public R GetDeterminant(Point a, Point b) {

			return Fro(a, b).getDeterminant();
		}

	}
}
