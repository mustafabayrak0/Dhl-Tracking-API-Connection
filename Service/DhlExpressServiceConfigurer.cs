using Shiptoboxes.External.Common;
using System;


namespace Shiptoboxes.External.DhlExpress
{
    public class DhlExpressServiceConfigurer
    {
        public DhlExpressServiceConfiguration Init(string shipmentUrl, string trackingUrl, string apiKey)
        {
            return new DhlExpressServiceConfiguration(shipmentUrl, trackingUrl, apiKey);
        }
    }

    public static class DhlExpressServiceFactoryExtensions
    {
        public static IDhlExpressService CreateDhlExpressService(this ServiceFactory source)
        {
            return new DhlExpressService();
        }

        public static void Configure(this IDhlExpressService service, Func<DhlExpressServiceConfigurer, DhlExpressServiceConfiguration> configurationDelegate)
        {
            service.Configure(configurationDelegate(new DhlExpressServiceConfigurer()));
        }
    }

    public class DhlExpressServiceConfiguration : IExternalServiceConfiguration
    {
        public string ShipmentUrl { get; }
        public string TrackingUrl { get; }
        public string ApiKey { get; }

        internal DhlExpressServiceConfiguration(string shipmentUrl, string trackingUrl, string apiKey)
        {
            ShipmentUrl = shipmentUrl;
            TrackingUrl = trackingUrl;
            ApiKey = apiKey;
        }
    }

}
