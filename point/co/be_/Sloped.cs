using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be_
{
	/// <summary>
	///	x is differnt such that the line is level or sloped, but never vertical.	
	/// </summary>
	public class SlopedDbl : BeDblA
	{
		//public bool be(CoD obj)
		//{
		//	return obj.begin.x != obj.end.x; 

		//	//throw new NotImplementedException();
		//}

		public override bool be(Point4dblI a, Point4dblI b)
		{
			return a.x != b.x;
		}


		static public SlopedDbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SlopedDbl>.Instance;
			}
		}


	}
}
