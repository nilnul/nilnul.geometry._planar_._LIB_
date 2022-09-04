using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.vect.co_
{
	public class Minus : CoI
	{
		public VectorI op(VectorI x, VectorI y)
		{
			return new Vector1(x.x.ToReal()-y.x.ToReal(), x.y.ToReal()-y.y.ToReal());


			throw new NotImplementedException();
		}


		static public Minus Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minus>.Instance;
			}
		}

	}
}
