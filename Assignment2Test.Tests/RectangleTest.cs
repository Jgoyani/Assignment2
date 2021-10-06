using Assignment2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Test.Tests
{
    public class Class1
    {
        [Test]
        public void SetLengthNegative()
        {
            var t = new Rectangle();
            int temp =  t.SetLength(-1);
            Assert.That(temp, Is.EqualTo(-1));
        }

        [Test]
        public void SetLengthPossitive()
        {
            var t = new Rectangle();
            int temp = t.SetLength(20);
            Assert.That(temp, Is.EqualTo(20));
        }

        [Test]
        public void SetLengthZero()
        {
            var t = new Rectangle();
            int temp = t.SetLength(0);
            Assert.That(temp, Is.EqualTo(0));
        }

        [Test]
        public void GetLengthNegative()
        {
            var t = new Rectangle();
            int temp = t.SetLength(20);
            int temp1 = t.GetLength();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void GetLengthZero()
        {
            var t = new Rectangle();
            int temp = t.SetLength(0);
            int temp1 = t.GetLength();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void GetLengthPossitive()
        {
            var t = new Rectangle();
            int temp = t.SetLength(23);
            int temp1 = t.GetLength();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void SetHeightNegative()
        {
            var t = new Rectangle();
            int temp = t.SetHeight(-11);
            Assert.That(temp, Is.EqualTo(-11));
        }

        [Test]
        public void SetHeightPossitive()
        {
            var t = new Rectangle();
            int temp = t.SetHeight(201);
            Assert.That(temp, Is.EqualTo(201));
        }

        [Test]
        public void SetHeightZero()
        {
            var t = new Rectangle();
            int temp = t.SetHeight(0);
            Assert.That(temp, Is.EqualTo(0));
        }

        [Test]
        public void GetHeightNegative()
        {
            var t = new Rectangle();
            int temp = t.SetHeight(201);
            int temp1 = t.GetHeight();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void GetHeightZero()
        {
            var t = new Rectangle();
            int temp = t.SetHeight(0);
            int temp1 = t.GetHeight();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void GetHeightPossitive()
        {
            var t = new Rectangle();
            int temp = t.SetHeight(213);
            int temp1 = t.GetHeight();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void SetWidthNegative()
        {
            var t = new Rectangle();
            int temp = t.SetWidth(-1);
            Assert.That(temp, Is.EqualTo(-1));
        }

        [Test]
        public void SetWidthPossitive()
        {
            var t = new Rectangle();
            int temp = t.SetWidth(20);
            Assert.That(temp, Is.EqualTo(20));
        }

        [Test]
        public void SetWidthZero()
        {
            var t = new Rectangle();
            int temp = t.SetWidth(0);
            Assert.That(temp, Is.EqualTo(0));
        }

        [Test]
        public void GetWidthNegative()
        {
            var t = new Rectangle();
            int temp = t.SetWidth(20);
            int temp1 = t.GetWidth();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void GetWidthZero()
        {
            var t = new Rectangle();
            int temp = t.SetWidth(0);
            int temp1 = t.GetWidth();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void GetWidthPossitive()
        {
            var t = new Rectangle();
            int temp = t.SetWidth(23);
            int temp1 = t.GetWidth();
            Assert.That(temp1, Is.EqualTo(temp));
        }

        [Test]
        public void GetVolume()
        {
            var t = new Rectangle();
            int h = t.SetHeight(5);
            int w = t.SetWidth(4);
            int l = t.SetLength(9);
            int temp = t.GetVolume();
            Assert.That(h * w * l, Is.EqualTo(temp));
        }

        [Test]
        public void GetVolumeZero()
        {
            var t = new Rectangle();
            int h = t.SetHeight(0);
            int w = t.SetWidth(4);
            int l = t.SetLength(9);
            int temp = t.GetVolume();
            Assert.That(h * w * l, Is.EqualTo(temp));
        }

        [Test]
        public void GetVolumeNegative()
        {
            var t = new Rectangle();
            int h = t.SetHeight(-5);
            int w = t.SetWidth(4);
            int l = t.SetLength(9);
            int temp = t.GetVolume();
            Assert.That(h * w * l, Is.EqualTo(temp));
        }
    }
}
