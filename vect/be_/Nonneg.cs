using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real;

namespace nilnul.geometry.planar.vect.be_
{
	/// <summary>
	/// in first quadrant (including boundary)
	/// </summary>
	public class Nonneg: vect.BeI1
		,
		vect.BeOfDoubleI
	{
		public bool be(IVector obj)
		{
			return (nilnul.num.real.be_.Nonneg.Singleton.be(obj.point.x)

				&& nilnul.num.real.be_.Nonneg.Singleton.be(obj.point.y)
			);
			
		}

		public bool be(Vector4dblI obj)
		{
			return obj.point.x >= 0 || obj.point.y >= 0;
		}

		static public Nonneg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg>.Instance;
			}
		}

	}
}
