using FindNthRootAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestFindNthRootAlgorithm
{
    /*
     * Реализовать алгоритм FindNthRoot, позволяющий вычислять
     * корень n-ой степени ( n ∈ N ) из вещественного числа 
     * а методом Ньютона с заданной точностью. 
     * Разработать модульные тесты (NUnit и (или) MS Unit Test) 
     * для тестирования метода.
     */

    [TestClass]
    public class TestFindNthRoot
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_1_FindNthRootMethod_Number_Degree_Precision_ArgumentOutOfRangeException()
        {
            // Arrange
            var find = new FindNthRoot();
            var inputNumber = -0.01;
            var inputDegree = 2;
            var inputPrecision = 0.0001;

            // Act
            var actualResult = find.GetRoot(inputNumber, inputDegree, inputPrecision);         
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_2_FindNthRootMethod_Number_Degree_Precision_ArgumentOutOfRangeException()
        {
            // Arrange
            var find = new FindNthRoot();
            var inputNumber = 0.001;
            var inputDegree = -2;
            var inputPrecision = 0.0001;

            // Act
            var actualResult = find.GetRoot(inputNumber, inputDegree, inputPrecision);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_3_FindNthRootMethod_Number_Degree_Precision_ArgumentOutOfRangeException()
        {
            // Arrange
            var find = new FindNthRoot();
            var inputNumber = 0.01;
            var inputDegree = 2;
            var inputPrecision = -1;

            // Act
            var actualResult = find.GetRoot(inputNumber, inputDegree, inputPrecision);
        }

        [TestMethod]
        public void Test_4_FindNthRootMethod()
        {
            // Arrange
            var find = new FindNthRoot();
            var inputNumber = 1;
            var inputDegree = 5;
            var inputPrecision = 0.0001;
            var expectedResult = 1;

            // Act
            var actualResult = find.GetRoot(inputNumber, inputDegree, inputPrecision);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_5_FindNthRootMethod()
        {
            // Arrange
            var find = new FindNthRoot();
            var inputNumber = 8;
            var inputDegree = 3;
            var inputPrecision = 0.0001;
            var expectedResult = 2;

            // Act
            var actualResult = find.GetRoot(inputNumber, inputDegree, inputPrecision);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_6_FindNthRootMethod()
        {
            // Arrange
            var find = new FindNthRoot();
            var inputNumber = 8;
            var inputDegree = 3;
            var inputPrecision = 0.0001;
            var expectedResult = 2;

            // Act
            var actualResult = find.GetRoot(inputNumber, inputDegree, inputPrecision);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
