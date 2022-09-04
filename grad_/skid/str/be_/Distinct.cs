
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.str.be_
{
	public class Distinct
		:
		planar.grad_.skid.str.Be4dblI
		
	{
		public bool be(IEnumerable<Skid4dblI> obj)
		{
			return nilnul.obj.str_.seq.be_.Distinct_eqDefault<
				grad_.Skid4dblI
				,
				grad.Eq4dbl
			>.Singleton.be(obj);
		}

		public bool be(IEnumerable<Grad4dbl_byPoints> enumerable)
		{
			return be(
				enumerable.Select(g=> new Skid4dbl(g.Item1,g.Item2) )
			);
		}
	
		public bool be(IEnumerable<Point4dblI> obj)
		{
			return be(
				sub_.directed_.connected_.chain.of_._VertexesX.Grads(obj)
			);
		
		}


		public bool be(params Point4dbl[] trio)
		{
			return be( (IEnumerable<Point4dbl>)(trio));
			;
		}


		static public Distinct Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Distinct>.Instance;
			}
		}

	}
}
