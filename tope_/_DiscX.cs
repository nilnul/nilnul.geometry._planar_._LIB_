using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		disc
	///			,where c means its perimeter is a cirle
	///		disk
	public interface IDisc { }
	static public class _DiscX
	{
		static public double Area(double r) {
			return Math.PI * r * r;
		}
	}
}
