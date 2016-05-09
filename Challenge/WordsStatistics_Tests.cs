using FluentAssertions;
using Kontur.Courses.Testing.Implementations;
using NUnit.Framework;
using System.Linq;

namespace Kontur.Courses.Testing
{
	[TestFixture]
	public class WordsStatistics_Tests
	{
		public virtual IWordsStatistics CreateStat()
		{
			// меняется на разные реализации при запуске exe
			return new WordsStatistics();
		}

		public IWordsStatistics stat;

		[SetUp]
		public void SetUp()
		{
			stat = CreateStat();
		}

		[Test]
		public void Empty_AfterCreation()
		{
			stat.GetStatistics().Should().BeEmpty();
		}

		[Test]
		public void SameWord_CountsOnce()
		{
			stat.AddWord("xxxxxxxxxx");
			stat.AddWord("xxxxxxxxxx");
			stat.GetStatistics().Count().Should().Be(1);
		}

		// FluentAssetions docs: http://www.fluentassertions.com/
	}

}