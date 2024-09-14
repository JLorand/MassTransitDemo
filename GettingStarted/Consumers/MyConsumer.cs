using System.Threading.Tasks;
using GettingStarted.Contracts;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace GettingStarted.Consumers;

public class MyConsumer(ILogger<MyConsumer> logger) : IConsumer<MyContract>
{
    public Task Consume(ConsumeContext<MyContract> context)
    {
        logger.LogInformation($"Hello {context.Message.Name}.");

        return Task.CompletedTask;
    }
}