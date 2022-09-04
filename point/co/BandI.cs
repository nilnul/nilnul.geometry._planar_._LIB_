using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co
{
	public interface BandDblI:nilnul.obj.co.BandI<Point4dblI, point.CoD>
	{
	}

	public abstract class BandOnCombineDblA :
		nilnul.obj.co.BandOnCombineA<Point4dblI, point.CoD>
		,
		BandDblI
	{
	}
}
