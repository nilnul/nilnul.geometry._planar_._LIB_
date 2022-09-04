using nilnul.geometry.planar.cycle_;
using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// the trigon's points are in postive rotation
	/// </summary>
	/// the default is defined by one edge from 0 to positive x. a 3rd point inner the +y halfplane <see cref="planar.surface_.sected_.WaiPositive"/>.
	public abstract class Trigon4dbl_onVertexesA
		: 
		planar.zone_.Trigon4dblI
	{
		


		public abstract IEnumerable<Point4dblI> vertexes { get; }
		public EeD points =>  EeD.Of(vertexes);

		public IEnumerable<Grad4dbl_byPointsI> grads => new Grad4dbl_byPointsI[] {
			new Grad4dbl_byPoints(vertexes.ElementAt(0),vertexes.ElementAt(1))
			,
			new Grad4dbl_byPoints(vertexes.ElementAt(1), vertexes.ElementAt(2))
			,
			new Grad4dbl_byPoints(vertexes.ElementAt(2) , vertexes.ElementAt(0))
		};
	}
}
