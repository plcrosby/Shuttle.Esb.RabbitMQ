﻿using NUnit.Framework;
using Shuttle.ESB.Tests;

namespace Shuttle.ESB.RabbitMQ.Tests
{
	public class RabbitMQResourceUsageTest : ResourceUsageFixture
	{
		[Test]
		[TestCase(false)]
		[TestCase(true)]
		public void Should_not_exceeed_normal_resource_usage(bool isTransactionalEndpoint)
		{
			TestResourceUsage("rabbitmq://shuttle:shuttle!@localhost/{0}", isTransactionalEndpoint);
		}
	}
}