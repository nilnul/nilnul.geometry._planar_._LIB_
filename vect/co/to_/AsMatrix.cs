using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real.matrix_.square_;

namespace nilnul.geometry.planar.vect.co.to_
{

	public class AsMatrix : ToI<nilnul.num.real.matrix_.square_.Secondary>
	{
		public Secondary to(Co src)
		{
			return _AsMatrixX.To(
				src
			);
			//throw new NotImplementedException();
		}

		public Secondary to(Vector1 vector1, Vector1 vector2)
		{
			return to(new Co(vector1, vector2));
			//throw new NotImplementedException();
		}


		static public AsMatrix Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<AsMatrix>.Instance;
			}
		}



	}
}
