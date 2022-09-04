using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.holed_.gon_
{
	public class Holed
		:planar.IFacet
	{
		private zone_.bloc_.ByVect4dbl _bloc;

		public zone_.bloc_.ByVect4dbl bloc
		{
			get { return _bloc; }
			//set { _bloc = value; }
		}

		private zone_.Disk4dbl _hole;

		public zone_.Disk4dbl hole
		{
			get { return _hole; }
			//set { _hole = value; }
		}

		public Holed(zone_.bloc_.ByVect4dbl bloc,zone_.Disk4dbl hole )
		{
			//vow hole is not intersected.

			var boundOfHole = hole.bounds;

			nilnul.obj_.bit.vow_._TrueX.Vow(
				tope_.bloc.re_.sup_.Proper4dbl.Singleton.re(
				bloc,
				hole.bounds
			)
				,
				"the hole must be fully within the board"

			);
			this._bloc = bloc;
			this._hole = hole;

		}


	}
}
