using nilnul.geometry.planar.zone_.gon_.octa_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable_
{
	/// <summary>
	/// a double arrow, a mark of txt
	/// </summary>
	/// <remarks>
	/// tag is a mark with a single anchor line; tape is a mark with two fixing points
	/// </remarks>
	public class Tape4dbl
	{
		private planar.zone_.gon_.octa_.BidirectionalArrow4Dbl _span;

		public planar.zone_.gon_.octa_.BidirectionalArrow4Dbl arrow
		{
			get { return _span; }
			set { _span = value; }
		}

		private string _caption;

		public string caption
		{
			get { return _caption; }
			set { _caption = value; }
		}

		public Tape4dbl(
			planar.zone_.gon_.octa_.BidirectionalArrow4Dbl arrow
			,
			string caption
		)
		{
			this._span = arrow;
			this._caption = caption;
		}

		public Tape4dbl(
			Point4dbl startOfInnerLine
			,
			Point4dbl endOfInnerLine
			,
			tope_._bloc.SpreadDbl arrowBounding
			,
			string caption

		)
		:
		this(
			new zone_.gon_.octa_.BidirectionalArrow4Dbl(startOfInnerLine,endOfInnerLine,arrowBounding)
			,
			caption
		)
		{
		}

		static public Tape4dbl OfTips(
			planar.Point4dbl start
			,
			planar.Point4dbl end
			,
			tope_._bloc.SpreadDbl arrowBounding
			,
			string caption

		) {



			
			return new Tape4dbl(
				BidirectionalArrow4Dbl.OfTips(
					start
					,
					end
					,
					arrowBounding
				)
				,caption
			);
		}
	}
}
