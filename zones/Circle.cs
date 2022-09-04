using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry
{
	public partial class Circle
		:CircleI
	{
		private RealI _radius;

		#region ICircle Members

		public nilnul.number.real.IReal radius
		{
			get
			{
				return _radius;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion
	}
}
