using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_
{
	/// <summary>
	/// </summary>
	public class Gon4dbl
		:
		
		cloze_.gon.be_.plural_.skids.vow.Ee4dbl
		,
		coil_.Gon4dblI
	{
		
		public Gon4dbl(cloze_.Polygon4dblI val) : base(val)
		{
		}

		public Gon4dbl(IEnumerable<Point4dblI> val) : this(
			new cloze_.Polygon4dbl(val)
		)
		{ }


		public IEnumerable<Point4dblI> vertexes => this.ee.vertexes;

		public IEnumerable<Grad4dbl_byPoints> grads {
			get {
				return cloze_.gon._Grads4dblX._Grads_ofStarted(vertexes);
			}
		}
	}
}
