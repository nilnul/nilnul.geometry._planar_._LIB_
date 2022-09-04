using nilnul.geometry.planar.grad_.skid_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid_.nonperspect
{
	/// <summary>
	/// Linear intERPolation
	/// </summary>
	public class Lerp4dbl
		:
		nilnul.obj.Box1<
			planar.grad_.skid_.Nonwai4dbl
		>
	{
		public Lerp4dbl(Nonwai4dbl val) : base(val)
		{
		}

		public Lerp4dbl(grad_.Skid4dblI val) : this(new Nonwai4dbl(val))
		{
		}

		public double vertical(double horizon) {

			return (
				boxed.basis.y * (boxed.finish.x - horizon)
				+
				boxed.finish.y * (horizon - boxed.basis.x)
			)
			/
			(boxed.finish.x - boxed.basis.x)
			;
		}
	}
}
