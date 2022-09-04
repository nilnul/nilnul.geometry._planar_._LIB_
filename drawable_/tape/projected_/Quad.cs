using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable_.tape.projected_
{
	/// <summary>
	/// a tape projected to two points
	/// </summary>
	public class Quad
		: nilnul.obj.Box_pub<drawable_.Tape4dbl>
	{

		private nilnul.geometry.planar.point.CoD _terminals;

		/// <summary>
		/// the two point where the length is measured
		/// </summary>
		public nilnul.geometry.planar.point.CoD terminals
		{
			get { return _terminals; }
			set { _terminals = value; }
		}

		private nilnul.num.real_.NonnegOfDouble _eave;

		/// <summary>
		/// how much the guidline pass over the tape.
		/// </summary>
		public nilnul.num.real_.NonnegOfDouble eave
		{
			get { return _eave; }
			set { _eave = value; }
		}


		public Quad(
			Tape4dbl val,
			nilnul.geometry.planar.point.CoD terminals0,nilnul.num.real_.NonnegOfDouble eave) : base(val)
		{

			/// two legs must be nonnil
			///
			nilnul.geometry.planar.point.co.be_.dif.VowDbl.Singleton.vow(
				terminals0.component1
				,
				val.arrow.beginTip
			);

			nilnul.geometry.planar.point.co.be_.dif.VowDbl.Singleton.vow(
				terminals0.component
				,
				val.arrow.endTip
			);

			this._terminals = terminals0;
			this._eave = eave;

		}

		public planar.Point4dblI eaveTipFirst
		{
			get
			{
				return (
					new nilnul.geometry.planar.grad_.skid_.ByPoints4Dbl(
						terminals.component
						,
						this.boxed.arrow.endTip
					) + _eave
				).end;
			}
		}
		public planar.Point4dblI eaveTipSecond
		{
			get
			{
				return (
					new nilnul.geometry.planar.grad_.skid_.ByPoints4Dbl(
						terminals.component1
						,
						this.boxed.arrow.beginTip
					) + _eave
				).end;
			}
		}

		public planar.grad_.Step4dbl guidFirst {
			get {
				return new grad_.Step4dbl(
					_terminals.component
					,
					eaveTipFirst
				);
			}
		}

		public planar.grad_.Step4dbl guidSecond {
			get {
				return new grad_.Step4dbl(
					_terminals.component1
					,
					eaveTipSecond
				);
			}
		}






	}
}
