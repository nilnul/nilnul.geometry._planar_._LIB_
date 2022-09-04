using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.co_.align.be_
{
	static public class _ParallelX 
	{
		static public bool _Be_ofAligned(LineI a, LineI _b)
		{
			return nilnul.geometry.planar.vect.re_.Angular.Singleton.re(
				 a.points.en.end- a.points.en.begin
				 ,
				 
				 _b.points.en.begin - a.points.en.begin
			);
		}
	}
}