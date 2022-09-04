using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint.be_
{
	 public class Has4dbl
		:Be4dblI
	{


		public  bool _be_assumeLead(
			Point4dblI leadStart, Point4dblI leadFinish, Point4dblI point
		)
		{
			return nilnul.num.real.be_.AboutNil4Dbl.Injected.be(
				cloze_.gon._SurroundedX._Stokes_ofStarted(
					leadStart
					,
					leadFinish
					,
					point
				)
			);
		}
		public  bool _be_assumeLead(
			(Point4dblI, Point4dblI) _assumeDif, Point4dblI point
		)
		{
			return _be_assumeLead(_assumeDif.Item1,_assumeDif.Item2,point);
		}
		public  bool be(Skid4dblI skid, Point4dblI x)
		{
			return _be_assumeLead(
				skid.basis
				,
				skid.finish
				,
				x
			);

		}
		 public bool be(planar.Lead4dblI lead,  Point4dblI x)
		{

			return be(
				lead.skid
				,
				x
			);
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
