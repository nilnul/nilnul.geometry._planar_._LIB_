using nilnul.geometry.planar.coil_.gon_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_
{

	public class Conduit4dbl
		:
		coil_.gon_.conduit.be_.facet.vow.Ee4dbl
		,
		Conduit4DblI
	{
		public Conduit4dbl(coil_.gon_.Conduit4dbl val) : base(val)
		{
		}
		public Conduit4dbl(
			IEnumerable<Point4dblI> vertexes
		):this(
			new coil_.gon_.Conduit4dbl(vertexes)
		)
		{

		}

		public Conduit4dbl(
			Point4dblI[] vertexes
		):this(
			(IEnumerable<Point4dblI> ) vertexes
		)
		{
	

		}


		//
		public IEnumerable<Grad4dbl_byPointsI> grads =>
			cloze_.gon._Grads4dblX._Grads_ofStarted(vertexes)
			;

		public IEnumerable<Point4dblI> vertexes => base.ee.ee.vertexes;
	}
}
