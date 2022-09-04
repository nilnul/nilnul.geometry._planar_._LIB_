using nilnul.geometry.planar.point.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.loop_
{
	/// <summary>
	/// a polygon that is not directed
	/// </summary>
	//[Obsolete(nameof(cloze_.IPolygon) + ". as cloze implies directable.",true)]
	public interface IPolygon
		:ILoop
		//,
		//sub_.directed_.connected_.IPolygon
	{
	}
}
