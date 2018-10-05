using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson
{
    public static class EquationSolver
    {
		public static double[] Solve(string equation)
		{
			var coefficients = GetCoefficients(equation);
			var discriminant = FindDiscriminant(coefficients);
			var hasRoots = HasRoots(discriminant);
			if (!hasRoots)
			{
				return new double[0];
			}

			var roots = FindRoots(coefficients, discriminant);
			return roots;
		}

		public static int[] GetCoefficients(string equation)
		{
			return new int[0];
		}

		public static double FindDiscriminant(int[] coefficients)
		{
			return 0;
		}

		public static bool HasRoots(double discriminant)
		{
			return true;
		}

		public static double[] FindRoots(int[] coefficients, double dicscriminant)
		{
			return new double[0];
		}
    }
}
