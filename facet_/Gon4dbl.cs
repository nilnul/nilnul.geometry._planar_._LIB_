﻿using nilnul.geometry.planar.cycle_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_
{

	/// <summary>
	/// holes and a contour
	/// </summary>
	public class Gon4dbl
		
	{
		private cycle_.gon_.Facade4dbl _contour;

		public cycle_.gon_.Facade4dbl contour
		{
			get { return _contour; }
			//set { _contour = value; }
		}


		private cycle_.gon_.antiwise.str_.Disjoint _holes;

		public cycle_.gon_.antiwise.str_.Disjoint holes
		{
			get { return _holes; }
			//set { _holes = value; }
		}

		

		public Gon4dbl(
			cycle_.gon_.Facade4dbl _contour0
						,
			cycle_.gon_.antiwise.str_.Disjoint holes0
		)
		{

			nilnul.bit.vow_.True1.Vow(
				holes0.ee.All(
					h
					=>
					cycle_.gon.co_.pro1con.be_.Donut4dbl.Singleton.re(_contour0, h)
				)
			);

			this._contour = _contour0;
			this._holes = holes0;
		}
		public Gon4dbl(Polygon4dblI contour1, IEnumerable<Polygon4dblI> children)
			:
			this(
				new cycle_.gon_.Facade4dbl(contour1)
				,
				new cycle_.gon_.antiwise.str_.Disjoint(children)
			)
		{
		}
		public Gon4dbl(Polygon4dblI contour1, params Polygon4dblI[] children)
			:
			this(
				contour1
				,
				( IEnumerable<Polygon4dblI>)(children)
			)
		{
		}


		public Gon4dbl(IEnumerable<planar.Point4dblI> contour1, IEnumerable<IEnumerable<planar.Point4dblI>> cycles)
			:this(
				 new cycle_.gon_.Facade4dbl(contour1)
				 ,

				 new cycle_.gon_.antiwise.str_.Disjoint(cycles)
			)
		{

		}

	}
}