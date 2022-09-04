using nilnul.geometry.planar;
using nilnul.geometry.planar.line.co.categorize_._positional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.line.co.be_
{
	/// <summary>
	/// same orientation. incident or parallel
	/// </summary>
	public  class Align:planar.line.co.BeOnReA
	{

		//public  bool be(Line x, Line y)
		//{
		//	return be((LineI)x, (LineI)y);
			
		//}

		public override bool re(LineI a, LineI b)
		{
			return planar.line._OrientationX.Orientation(a) == planar.line._OrientationX.Orientation(b);
		}


		static public Align Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Align>.Instance;
			}
		}

	}
}
