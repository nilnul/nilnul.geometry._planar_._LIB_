using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be_
{
	/// <summary>
	///		
	/// </summary>
	public class ReflexiveD :
		point.co.BeOnReDA
		,
		point.co._be_.IOfD
		,
		point.IReD
	{
		
		public override bool re(Point4dblI a, Point4dblI b)
		{
			return a == b; 

		}

		static public ReflexiveD Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ReflexiveD>.Instance;
			}
		}




	}
}
