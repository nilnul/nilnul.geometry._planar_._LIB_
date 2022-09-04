using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.ray_
{
	/// <summary>
	/// a ray start at origin
	/// </summary>
	public class Affine : linear.Ray
	{

		public Affine( bool direction) : base(0, direction)
		{
		}
	}
}
