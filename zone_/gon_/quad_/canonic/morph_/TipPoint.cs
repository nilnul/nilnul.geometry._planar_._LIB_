using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad_.canonic.morph_
{
	/// <summary>
	/// just stuff the figure as a rect. morph it. and then remove the stuff.
	/// </summary>
	/// <see cref="zone_.gon_.quad.Parameterize"/>
	public class TipPoint
		:
		nilnul.obj.Box1<
			planar.point_.PositivesDbl
		>
		,
		drawable._morph_.OfPoint4DblI

	{
		public TipPoint(PositivesDbl val) : base(val)
		{
		}

		private PositivesDbl _newTip;

		public PositivesDbl newTip
		{
			get { return _newTip; }
			set { _newTip = value; }
		}

		public Point4dblI morph(Point4dblI original)
		{

			var horizon = new Horizon(
				this.boxed
			)
			{ newTip= this._newTip.xAsPoistive};

			var transed = horizon.morph(
				original
			);

			var horizonTransedTip = new Point4dbl( this._newTip.x, this.boxed.y); 

			var vertical = new Vertical(
				horizonTransedTip
			);

			return vertical.morph(transed);


			//throw new NotImplementedException();
		}
	}
}
