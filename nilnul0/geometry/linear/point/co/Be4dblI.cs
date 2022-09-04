using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co
{
	public interface Be4dblI:nilnul.obj.BeI1<linear.point.CoDbl>
	{
	}

	public abstract class Be4dblA :
		nilnul.obj.co.BeA<linear.PointDblI, linear.point.CoDbl>
		,
		Be4dblI
	{
	}
	public class Be4dbl :
		nilnul.obj.Be1<linear.point.CoDbl>
		,
		Be4dblI
	{
		public Be4dbl(Func<CoDbl, bool> func) : base(func)
		{
		}
	}
}
