using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.tend_
{
	/// <summary>
	/// the length is not nil
	/// </summary>
	/// alias:
	///		seg
	///		span
	///		edge

	public interface ISeg :  ITend, curve_.IBounded, trace_.ISpanned
	{

	}
}
