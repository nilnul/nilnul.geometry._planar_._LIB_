using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.vect_.nonnil.co.rotation
{
	
	public class Categorize : nilnul.obj.CategorizeI<Co, _categorize.Category>
	{
		public _categorize.Category categorize(Co obj)
		{
			return categorize(obj.component,obj.component1);
		}
		public _categorize.Category categorize(NonnilI a, NonnilI b) {

			var ax = a.point.x.ToReal();
			var ay = a.point.y.ToReal();
			var bx = b.point.x.ToReal();
			var by = b.point.y.ToReal();

			var sin = nilnul.geometry.planar.vect.co._CrossProductX.AreaOfParallelogram(
				a, b).ToReal();

			if (sin > 0 )
			{
				return _categorize.Category.Angular;

			}
			if (sin<0)
			{
				return _categorize.Category.Overbend;
			}

			var cos=nilnul.geometry.planar.vect.co.to_.real_._DotProductX.RealI(a,b).ToReal();


			if (cos>0)
			{
				return _categorize.Category.Nil;
			}

			
			return _categorize.Category.Pi;
		}


		static public Categorize Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Categorize>.Instance;
			}
		}



	}
}
