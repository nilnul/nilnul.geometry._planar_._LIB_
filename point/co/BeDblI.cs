using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co
{
	[Obsolete()]
	public interface IBeD
		:

		nilnul.obj.BeI1<planar.point.CoD>
	{
	}

	public interface BeDblI
		:

		nilnul.obj.BeI1<planar.point.CoD>
	{
	}

	[Obsolete()]
	public abstract class BeDA
		:
		nilnul.obj.co.BeA< planar.Point4dblI, planar.point.CoD>
	{

	}

	public abstract class BeDblA
		:
		nilnul.obj.co.BeA< planar.Point4dblI, planar.point.CoD>
		,
		BeDblI
	{

	}

	public abstract class BeOnReDA
		:
		nilnul.obj.co.BeOnReA< planar.Point4dblI, planar.point.CoD>
	{

	}

}
