using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured
{
	public interface Mark4dblI<T>
		:
		nilnul.obj._measure_.Unit4dblI<T> //for measure the quantity cannot be negative. Here, the quatity can be negative, but the negative part is proportional and can be mapped to the nonneg part. So we use the same defintion of Unit from measure.
		//in other words, this ian extension of the unit.
		,
		nilnul.obj._metric_.Quantity4dblI //for metric, the quantity can be any double value. But for metric, the quantity is not necessarily linear proportional, nor shares the same origin . We here use the metric quantity definition, cuz they annotate the same constraint: any double value, negative or nonnegative.
		where T : nilnul.obj._measure.Unit4dblI
	{
		//double quantity { get; set; }
	}

	public class Mark4dblA<T>
		:
		nilnul.obj._measure_.Unit4dblA<T>
		,
		Mark4dblI<T>

		where T : nilnul.obj._measure.Unit4dblI
	{
		private double _quantity;

		public double quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

		public Mark4dblA(double quantity0, T unit) : base(unit)
		{
			this._quantity = quantity0;
		}

		public double toStd() {
			return _quantity * this.unit.magnitude.dblen.ee;
		}

		public override string ToString()
		{
			return $"{this._quantity }{this.unit}";
		}



	}
}
