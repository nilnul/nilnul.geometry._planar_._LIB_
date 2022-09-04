using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad_.canonic.morph_
{
	/// <summary>
	/// </summary>
	public class Vertical
		:
		nilnul.obj.Box1<
			planar.point_.PositivesDbl
		>
		,
		drawable._morph_.OfPoint4DblI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">old tip point</param>
		public Vertical(PositivesDbl val) : base(val)
		{
		}

		public Vertical(Point4dblI point4dblI):this(
			PositivesDbl.Of(point4dblI)
		)
		{
		}

		private nilnul.num.real_.PositiveDblI _newTip;
		public nilnul.num.real_.PositiveDblI newTip
		{
			get { return _newTip; }
			set { _newTip = value; }
		}

		public PositivesDbl oldTip { get { return boxed; } }

		public Point4dblI morph(Point4dblI oldPoint2trans)
		{

			var horizon = new Horizon(
				new PositivesDbl(this.boxed.y, this.boxed.x)
			)
			{
				newTip = this._newTip
			};

			var transed = horizon.morph(oldPoint2trans);
			return new Point4dbl(
				transed.y
				,
				transed.x
			);

		}
	}
}