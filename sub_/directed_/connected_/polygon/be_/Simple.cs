using System;
using System.Text;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_;
using nilnul.objs;
namespace nilnul.geometry.planar.sub_.directed_.connected_.polygon.be_
{

	/// <summary>
	/// don't intersect itself
	/// </summary>
	public  class Simple : BeI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool be(PolygonI obj)
		{

			return _SimpleX._Simple_ofPolyDif(obj.vertexes);

			//throw new NotImplementedException();
		}


		static public Simple Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Simple>.Instance;
			}
		}

	}
}
