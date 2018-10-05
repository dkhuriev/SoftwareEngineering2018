using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLesson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstLessonTests
{
	[TestClass]
	public class EquationSolverTests
	{
		[TestMethod]
		public void ParseValidEquationString_ReturnsCoefficients()
		{
			var equation = "4x^2-12x+4=0";
			var aCoefficient = 4;
			var bCoefficient = -12;
			var cCoefficient = 4;

			var actualCoefficients = EquationSolver.GetCoefficients(equation);

			Assert.AreEqual(aCoefficient, actualCoefficients[0]);
			Assert.AreEqual(bCoefficient, actualCoefficients[1]);
			Assert.AreEqual(cCoefficient, actualCoefficients[2]);
		}
	}
}
