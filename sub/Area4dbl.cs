using nilnul.geometry.planar._area;
using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
namespace nilnul.geometry.planar
{

	public class Area4dbl<TUnit>
		:
		nilnul.obj.Measure4dbl<TUnit>
		,
		Area4dblI<TUnit>

		where TUnit : _area.Unit4dblI
	{
		public Area4dbl(NonnegOfDoubleI amount, TUnit unit) : base(amount, unit)
		{
		}

		public Area4dbl(NonnegOfDouble amount, TUnit unit) : base(amount, unit)
		{
		}

		public Area4dbl(double amount, TUnit unit) : base(amount, unit)
		{
		}

		public Area4dbl(long amount, TUnit unit) : base(amount, unit)
		{
		}

		public Area4dbl(int amount, TUnit unit) : base(amount, unit)
		{
		}
	}

	public class Area4dbl :

		Area4dbl<_area.Unit4dblI>
	{
		public Area4dbl(NonnegOfDoubleI amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Area4dbl(NonnegOfDouble amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Area4dbl(double amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Area4dbl(long amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Area4dbl(int amount, Unit4dblI unit) : base(amount, unit)
		{
		}


		public Area4dbl(NonnegOfDoubleI amount) : this(amount, _area.Unit4dbl.Singleton)
		{
		}

		public Area4dbl(NonnegOfDouble amount) : this(amount, _area.Unit4dbl.Singleton)
		{
		}

		public Area4dbl(double amount) : this(amount, _area.Unit4dbl.Singleton)
		{
		}

		public Area4dbl(long amount) : this(amount, _area.Unit4dbl.Singleton)
		{
		}

		public Area4dbl(int amount) : this(amount, _area.Unit4dbl.Singleton)
		{
		}

	}
}
