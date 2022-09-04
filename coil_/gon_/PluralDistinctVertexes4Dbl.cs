using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_
{
	/// <summary>
	/// the points are distinct. We have at least two vertexes.
	/// the edges might cross.
	/// </summary>
	public class PluralDistinctVertexes4Dbl
		:
		
		point.str.be_.plural_.distinct.vow.Ee4dbl
		,
		Gon4dblI
	{
		

		public PluralDistinctVertexes4Dbl(IEnumerable<Point4dblI> val) : base(val)
		{ }


		public IEnumerable<Point4dblI> vertexes => this.ee;

		public IEnumerable<Grad4dbl_byPoints> grads {
			get {
				return cloze_.gon._Grads4dblX._Grads_ofStarted(vertexes);
			}
		}
	}
}
