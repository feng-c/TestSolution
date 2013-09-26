using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestProject;

namespace TestProject.Tests
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void TestCube()
        {
            int expected = 27;
            int actual = Program.Cube(3);



            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestFunction()
        {
            int expected = 25;
            int actual = Program.Square(5);

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}