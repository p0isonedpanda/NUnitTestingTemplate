using NUnit.Framework;
using MyProject;

namespace MyProject.UnitTests
{
	[TestFixture]
	public class Tests
	{
		private readonly Program _myProject;

                public Tests()
		{
			_myProject = new Program();
		}

		[Test]
		public void TestReturnTrue()
		{
			var result = _myProject.ReturnTrue();

			Assert.IsTrue(result);
		}
	}
}
