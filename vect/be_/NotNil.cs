using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real;

namespace nilnul.geometry.planar.vect.be_
{
	public class NotNil : vect.BeI1
		,
		vect.BeOfDoubleI
		,
		vect.Be4dblI
	{
		public bool be(IVector obj)
		{
			return !(nilnul.num.real.be_.Nil.Singleton.be(obj.point.x)

				&& nilnul.num.real.be_.Nil.Singleton.be(obj.point.y)
			);
			
		}

		public bool be(Vector4dblI obj)
		{
			return obj.point.x != 0 || obj.point.y != 0;
		}

		public bool be(Vect4dblI obj)
		{
			return !(nilnul.num.real.be_.AboutNil4Dbl.Injected.be(obj.point.x)

				&& nilnul.num.real.be_.AboutNil4Dbl.Injected.be(obj.point.y)
			);

		}

		static public NotNil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NotNil>.Instance;
			}
		}

	}
}
