using Xunit;
using PersonClassLibrary;
using System;

namespace PersonTests
{
    public class PersonTests
    {
        [Fact]
        public void TrueTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void EnterValidNameTest()
        {
            string name = "Jon";
            var p1 = new Person(name);
            Assert.Equal(p1.Name, name);
        }

        [Fact]
        public void ThorwsExceptionNameTooShort()
        {
            Assert.Throws<ArgumentException>(
                () => { var p1 = new Person("Jo"); }
            );
        }
  
    }
}