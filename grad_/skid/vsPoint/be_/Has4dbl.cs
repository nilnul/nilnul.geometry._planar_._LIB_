using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid.vsPoint.be_
{


	/// <summary>
	/// colinear and inbetween the end points
	/// </summary>
	 public  class Has4dbl
		:
		Be4dblI
	{
		static public bool be(
			 grad_.Arrow arrow
			,
			planar.Point1 p
		)
		{
			if (planar.line.be_.HasPointX.Bit(arrow.points,p))
			{
				return grad_.skid.vsPoint_.colinear.be_._ArrowHasPointX._ofColinear(arrow,p);

			}
			return false;
		}
		public bool _be_assumeSkid(Grad4dbl_byPointsI x, Point4dblI y)
		{
			if (planar.lead.vsPoint.be_.Has4dbl.Singleton._be_assumeLead(
				x.basis,x.finish,y
			)
			)
			{
				return grad_.skid.vsPoint_.colinear.be_._HasX._Has_assumeSkid_assumeColinear(
					x,y
				);
			}
			return false;


		}

		public bool be(Skid4dblI lead, Point4dblI point)
		{
			if (planar.lead.vsPoint.be_.Has4dbl.Singleton.be(lead,point) )
			{
				return grad_.skid.vsPoint_.colinear.be_._HasX._ofColinear(
					lead,point
				);
			}
			return false;
		}


		static public Has4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Has4dbl>.Instance;
			}
		}

	}
}
