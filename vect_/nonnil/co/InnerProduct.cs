using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co
{
	public class InnerProduct
		:
		nilnul.obj.ToI<
			vect_.nonnil.Co4dbl
			,
			double
		>
	{
		public double to(Co4dbl src)
		{
			return vect.co.to_.real_._DotProductX.Dbl(
				src.component.vectoree.ee
				,
				src.component1.vectoree.ee
			);
			//throw new NotImplementedException();
		}


		static public InnerProduct Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<InnerProduct>.Instance;
			}
		}

	}
}
