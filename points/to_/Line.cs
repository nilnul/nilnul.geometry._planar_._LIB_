using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math = System.Math;

namespace nilnul.img.to.geometry
{
	/*
	我也贡献个直线拟合的代码吧
发信站: 水木社区(Sat Mar 12 17:23:03 2016), 站内

这个代码是我以前学习《机器视觉算法与应用（双语版）》[德]
	斯蒂格（Steger C） 著；杨少荣 等 译 的书时写的。

所有的公式推导都在书中 3.8.1 ，还算比较有用。比普通的一元线性回归拟合的结果要好。

另外，我准备陆续把我以前写的一些代码都整理一下，放到网上。现在整理了一小部分。放到了下面。
https://code.csdn.net/liyuanbhu/computervisioncode

#include <QVector>
#include <QPoint>
#include <math.h>
*/

	/// 本代码用到了 Qt5 中的 QVector 和 QPoint。但是可以很容易的改为其他数组类型。

	/**
	 * 最小二乘法直线拟合（不是常见的一元线性回归算法）
	 * 将离散点拟合为  a x + b y + c = 0 型直线
	 * 假设每个点的 X Y 坐标的误差都是符合 0 均值的正态分布的。
	 * 与一元线性回归算法的区别：一元线性回归算法假定 X 是无误差的，只有 Y 有误差。
	 */

	public class Line
	{
		bool lineFit(nilnul.geometry.planar.Point4dbl[] points, double a, double b, double c)
		{
			int size = points.Length;
			if (size < 2)
			{
				a = 0;
				b = 0;
				c = 0;
				return false;
			}
			double x_mean = 0;
			double y_mean = 0;
			for (int i = 0; i < size; i++)
			{
				x_mean += points[i].x;
				y_mean += points[i].y;
			}
			x_mean /= size;
			y_mean /= size; //至此，计算出了 x y 的均值

			double Dxx = 0, Dxy = 0, Dyy = 0;

			for (int i = 0; i < size; i++)
			{
				Dxx += (points[i].x - x_mean) * (points[i].x - x_mean);
				Dxy += (points[i].x - x_mean) * (points[i].y - y_mean);
				Dyy += (points[i].y - y_mean) * (points[i].y - y_mean);
			}
			double lambda = ((Dxx + Dyy) - Math.Sqrt((Dxx - Dyy) * (Dxx - Dyy) + 4 * Dxy * Dxy)) / 2.0;
			double den = Math.Sqrt(Dxy * Dxy + (lambda - Dxx) * (lambda - Dxx));
			a = Dxy / den;
			b = (lambda - Dxx) / den;
			c = -a * x_mean - b * y_mean;
			return true;
		}

	}

}
