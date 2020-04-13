using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace TDD_Example.Tests
{
    [TestClass()]
    public class Vector3Tests
    {
        [TestMethod()]
        public void ConstructorDoesNotThrowExceptionTest()
        {
            bool threwException = false;
            try
            {
                Vector3 vector = new Vector3();
            }
            catch
            {
                threwException = true;
            }

            Assert.IsFalse(threwException);
        }

        [TestMethod()]
        public void ConstructorWithParametersWillSetValuesCorrectlyTest()
        {
            Vector3 vector = new Vector3(1, 2, 3);

            Assert.AreEqual(1, vector.x);
            Assert.AreEqual(2, vector.y);
            Assert.AreEqual(3, vector.z);
        }

        [TestMethod()]
        public void AddOverloadIncreasesValueOfVectorByCorrectAmountTest()
        {
            Vector3 vector1 = new Vector3(1, 1, 1);
            Vector3 vector2 = new Vector3(1, 1, 1);

            vector1 = vector1 + vector2;

            Assert.AreEqual(2, vector1.x);
            Assert.AreEqual(2, vector1.y);
            Assert.AreEqual(2, vector1.z);
        }

        [TestMethod()]
        public void GetMagnitudeReturnsTheCorrectValueTest()
        {
            Vector3 vector = new Vector3(5, 5, 5);
            float mag = vector.GetMagnitude();

            Assert.AreEqual(8.6602545f, mag);
        }

        [TestMethod()]
        public void NormalizeVectorWillNormalizeAVectorTest()
        {
            Vector3 vector = new Vector3(1, 2, 3);
            vector.Normalize();

            Assert.AreEqual(0.26726f, vector.x, 0.0001f);
            Assert.AreEqual(0.5345f, vector.y, 0.0001f);
            Assert.AreEqual(0.8018f, vector.z, 0.0001f);    
        }

        [TestMethod()]
        public void GetNormalVectorWillReturnTheNormalButNotNormalizeTheVectorTest()
        {
            Vector3 vector = new Vector3(1, 1, 1);
            Vector3 normalizedVector = vector.GetNormal();

            Assert.AreEqual(0.5774f, normalizedVector.x, 0.0001f);
            Assert.AreEqual(0.5774f, normalizedVector.y, 0.0001f);
            Assert.AreEqual(0.5774f, normalizedVector.z, 0.0001f);

            Assert.AreEqual(1, vector.x);
            Assert.AreEqual(1, vector.y);
            Assert.AreEqual(1, vector.z);
        }

        [TestMethod()]
        public void GetDotProductReturnsCorrectValueTest()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);
            Vector3 vector2 = new Vector3(4, 5, 6);

            float dot = vector1.GetDotProduct(vector2);

            Assert.AreEqual(0.9746318f, dot, 0.00001f);
        }
    }
}

namespace TDD_ExampleTests
{
    class Vector3Tests
    {
    }
}