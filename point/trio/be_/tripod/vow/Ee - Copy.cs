using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_.tripod.vow
{
	public class EeD
		:
		planar.point.trio.vow.ee_.VowDefaultD<planar.point.trio.be_.tripod.VowD>
	{



		public EeD(TrioD val) : base(val)
		{
		}

		static public EeD Of(IEnumerable<Point4dblI> vertexes)
		{
			nilnul.bit.vow_.True1.Vow(nilnul.obj.str.be_.Poly<Point4dblI>.Singleton.be(vertexes)
			);
			return new EeD(
				vertexes.First()
				,
				vertexes.ElementAt(1)
				,
				vertexes.Last()
			);

		}

		public EeD(Point4dblI alfa, Point4dblI bravo, Point4dblI charlie):this(new TrioD(alfa,bravo,charlie))
		{
		}

	}






}


