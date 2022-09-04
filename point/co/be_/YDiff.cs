using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be_
{
	/// <summary>
	/// </summary>
	public class YDif : co.BeOnReA
	{
		public override bool re(planar.Point1 obj, planar.Point1 b)
		{
			return obj.y != b.y; 

			//throw new NotImplementedException();
		}

		static public YDif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<YDif>.Instance;
			}
		}

	}
}
