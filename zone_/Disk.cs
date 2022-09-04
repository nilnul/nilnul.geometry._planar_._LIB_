using nilnul.geometry.planar.curve_.cloze_.circ_;
using nilnul.geometry.planar.loop_.circ_;
using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	public class Disk4dbl
		: nilnul.obj.Box1<
			loop_.circ_.Nontrivia4dbl
		>
	{
		public loop_.circ_.Nontrivia4dbl circ { get {
				return boxed;
			} }
		public Disk4dbl(Nontrivia4dbl val) : base(val)
		{
		}

		

		public IEnumerable<Polar4dbl_radius1st> _sect_assumePositive(int countOfSlices) {
			var step = Math.PI * 2 / countOfSlices;
			var total = 0d;

			for (int i = 0; i < countOfSlices; i++)
			{
				yield return new point_.Polar4dbl_radius1st(
					this.boxed.radius
					,
					total
				);

				total += step;

			}
		}
	

		public nilnul.geometry.planar.zone_.Bloc4dbl_byBounds bounds {
			get {
				var centerX = nilnul.num.real.bound_._CenteredDblX.Marks_ofCenterReach(
					boxed.center.x
					,
					boxed.radius.en
				);

				var centerY = nilnul.num.real.bound_._CenteredDblX.Marks_ofCenterReach(
					boxed.center.y
					,
					boxed.radius.en
				);


				return new Bloc4dbl_byBounds(
					new num.real.bound_.closed_.Spanned4dbl(
						centerX
					)
					,
					new num.real.bound_.closed_.Spanned4dbl(
						centerY
					)

				);
			}
		}

	}
}
