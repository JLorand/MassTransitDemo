using MassTransit;

namespace GettingStarted.Consumers
{
    public class MyConsumerDefinition : ConsumerDefinition<MyConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<MyConsumer> consumerConfigurator,
            IRegistrationContext context)
        {
            base.ConfigureConsumer(endpointConfigurator, consumerConfigurator, context);
            
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}