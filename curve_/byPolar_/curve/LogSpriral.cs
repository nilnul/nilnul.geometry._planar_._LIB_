using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PositiveD = nilnul.num.real.double_.b.Positive.Asserted;

namespace nilnul.geometry.planar.polar.curve
{
	public class LogSpriral
	{
		private nilnul.num.real.double_.b.Positive.Asserted _a;

		public PositiveD a
		{
			get { return _a; }
			set { _a = value; }
		}

		private PositiveD _b;

		public PositiveD b
		{
			get { return _b; }
			set { _b = value; }
		}

		 public double r_by_Angle(double angle) {
			return a * Math.Exp(b * angle);
		}

		public double angleByR(double r) {

			return 1 / b * Math.Log(r / a);
		}

		public double rByT(double t) {
			return a * Math.Exp(b*t);
		}


		public double x_by_t(double t) {
			return rByT(t) * Math.Cos(t);
		}

		public double y_by_t(double t) {
			return rByT(t) * Math.Sin(t);
		}

		/*
		
		发信人: nkplayer (:)), 信区: Mathematics
标  题: 螺旋线方程求助
发信站: 水木社区 (Tue Mar 22 16:51:45 2016), 站内

想找一个螺旋线的方程，满足的条件为，切线方向与径向成45度。

谢谢。
--

※ 来源:·水木社区 http://www.newsmth.net·[FROM: 61.181.249.*]



[本篇全文] [回复文章] [本篇作者：nkplayer] [回信给作者] [进入讨论区] [返回顶部][分享到 搜狐微博 腾讯微博 新浪微博]
2

发信人: nkplayer (:)), 信区: Mathematics
标  题: Re: 螺旋线方程求助
发信站: 水木社区 (Tue Mar 22 19:54:46 2016), 站内

居然让我找到了，等角螺旋线或者说对数螺旋线。
		
		*/





	}
}
