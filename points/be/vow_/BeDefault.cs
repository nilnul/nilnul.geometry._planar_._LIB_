using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.be.vow_
{
	public class BeDefaultDbl<TBe> : points.be.VowDbl
		where TBe: nilnul.obj.BeI1<IEnumerable<Point4dbl>>,new()
	{
		public BeDefaultDbl() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefaultDbl<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaultDbl<TBe>>.Instance;
			}
		}



	}
}
