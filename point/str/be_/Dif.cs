using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.be_
{
	/// <summary>
	/// </summary>
	public class Dif :
		BeI
	{
		public bool be(PointsI1 obj)
		{
			return nilnul.objs.be_.Diff<PointI, nilnul.geometry.planar.point.Eq2>.Singleton.be(obj);
			//throw new NotImplementedException();
		}


		static public Dif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dif>.Instance;
			}
		}

	}
}
