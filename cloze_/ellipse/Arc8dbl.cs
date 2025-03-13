using nilnul.geometry.planar.curve_.elliptic_;
using nilnul.num.complex.dich_._ortho_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse
{
	/// <summary>
	/// 
	/// </summary>
	/// <param name="ellipse"></param>
	/// <param name="startAngle"> will be normalized to <see cref="planar.rotation_.IDirective"/></param>
	/// <param name="sweep">
	/// <see cref="planar.rotation_.IDirective"/>; but in some cases, it can be used when it's beyond (lt or gt) <see cref="planar.rotation_.IDirective"/>;
	/// </param>
	public record struct Arc8dbl(
		   cloze_.Ellipse ellipse, double startAngle, double sweep
   ) : _troll_.Fn4dblI
	{
		public C locus(double time)
		{
			if (time < 0)
			{
				return ellipse.locus(startAngle);

			}
			if (time > sweep)
			{
				return ellipse.locus(startAngle + sweep);


			}
			return ellipse.locus(startAngle + time);

		}

	







		}

	
}
