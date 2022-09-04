using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.vsTend.be_
{
	
	/// <summary>
	/// joint. share at least one point.
	/// </summary>
	public class Joint4dbl :Be4dblI
	{
		public bool _be_assumeLine((Point4dblI,Point4dblI) _x_assumeLine, (Point4dblI,Point4dblI) y)
		{
			var tendStartPosition = planar.lead.vsPoint._LayoutX._LeewayTrue_assumeLead(
				_x_assumeLine,y.Item1
			);

			var tendEndPosition = planar.lead.vsPoint._LayoutX._LeewayTrue_assumeLead(
				_x_assumeLine,y.Item2
			);

			return nilnul.bit.nulable.op_.binary_.Multi.Singleton.op(
				tendStartPosition
				,
				tendEndPosition
			) !=true;


		}
		public bool _be_assumeLine((Point4dblI basis, Point4dblI finish) p, Grad4dbl_byPointsI y)
		{
			return _be_assumeLine(
				p
				,
				(y.basis,y.finish)
			);
		}


		public bool _be_assumeLine(Grad4dbl_byPointsI x, Grad4dbl_byPointsI y)
		{
			return _be_assumeLine(
				(x.basis,x.finish)
				,y
			);

		}

		public bool be(LineDbl line, Tend4dblI tend)
		{
			return _be_assumeLine(
				(line.ee.component,line.ee.component1)
				,
				(tend.points.component,tend.points.component1)
			);
		}

		static public Joint4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Joint4dbl>.Instance;
			}
		}


	}
}
