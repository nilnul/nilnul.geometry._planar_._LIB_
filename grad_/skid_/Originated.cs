using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.arrow_
{
	public class OriginatedDbl : grad_.skid_.ByPoints4Dbl
	{

		public OriginatedDbl( Point4dbl end) : base(new Point4dbl(), end)
		{
		}
	}
	/// <summary>
	/// also known as vector_.Nonnil
	/// </summary>
	static public class OriginatedX
	{
		static public grad_.arrow_.OriginatedDbl Arrow(planar.vect_.NonnilDblI vectorDbl)
		{
			return new grad_.arrow_.OriginatedDbl(vectorDbl.point);
		}
	}
}
