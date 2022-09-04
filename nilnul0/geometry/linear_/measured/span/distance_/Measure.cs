using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.real;

namespace nilnul.measure
{
	public class Measure:IMeasure
	{
		private IUnit _unit;
		private IReal _quantity;

		public Measure(IReal quantity,IUnit unit) {
			this.unit = unit; 
			this.quantity = quantity;
		}

		#region IMeasure Members

		public IUnit unit
		{
			get
			{
				return _unit; ;
			}
			set
			{
				_unit = value;
			}
		}

		public nilnul.real.IReal quantity
		{
			get
			{
				return _quantity;
			}
			set
			{
				_quantity = value;
			}
		}

		#endregion
	}
}
