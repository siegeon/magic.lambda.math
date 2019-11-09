/*
 * Magic, Copyright(c) Thomas Hansen 2019, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using System.Linq;
using Xunit;

namespace magic.lambda.math.tests
{
    public class MathTests
    {
        [Fact]
        public void Add()
        {
            var lambda = Common.Evaluate(@"

math.add
   :int:5
   :int:7");
            Assert.Equal(12, lambda.Children.First().Value);
        }

        [Fact]
        public void AddWithBase()
        {
            var lambda = Common.Evaluate(@"

math.add:int:2
   .:int:5
   .:int:7");
            Assert.Equal(14, lambda.Children.First().Value);
        }

        [Fact]
        public void AddExpression()
        {
            var lambda = Common.Evaluate(@"

math.add
   .:x:./+
   .:int:7
.:int:5");
            Assert.Equal(12, lambda.Children.First().Value);
        }

        [Fact]
        public void AddExpressionWithBase()
        {
            var lambda = Common.Evaluate(@"

math.add:x:+
   .:int:7
.:int:5");
            Assert.Equal(12, lambda.Children.First().Value);
        }

        [Fact]
        public void Subtract()
        {
            var lambda = Common.Evaluate(@"

math.subtract
   .:int:8
   .:int:5
   .:int:1");
            Assert.Equal(2, lambda.Children.First().Value);
        }

        [Fact]
        public void Multiply()
        {
            var lambda = Common.Evaluate(@"

math.multiply
   :int:2
   :int:2
   :int:3");
            Assert.Equal(12, lambda.Children.First().Value);
        }

        [Fact]
        public void Modulo()
        {
            var lambda = Common.Evaluate(@"

math.modulo:int:7
   :int:5");
            Assert.Equal(2, lambda.Children.First().Value);
        }

        [Fact]
        public void Divide()
        {
            var lambda = Common.Evaluate(@"

math.divide
   :int:12
   :int:2");
            Assert.Equal(6, lambda.Children.First().Value);
        }

        [Fact]
        public void Increment()
        {
            var lambda = Common.Evaluate(@"
.foo:int:4
math.increment:x:-");
            Assert.Equal(5, lambda.Children.First().Value);
        }

        [Fact]
        public void Decrement()
        {
            var lambda = Common.Evaluate(@"
.foo:int:5
math.decrement:x:-");
            Assert.Equal(4, lambda.Children.First().Value);
        }

        [Fact]
        public void IncrementMultipleNodes()
        {
            var lambda = Common.Evaluate(@"
.foo:int:4
.foo:int:4
math.increment:x:../*/.foo");
            Assert.Equal(5, lambda.Children.First().Value);
            Assert.Equal(5, lambda.Children.Skip(1).First().Value);
        }

        [Fact]
        public void IncrementWithStep()
        {
            var lambda = Common.Evaluate(@"
.foo:int:4
math.increment:x:-
   :int:3");
            Assert.Equal(7, lambda.Children.First().Value);
        }
    }
}
