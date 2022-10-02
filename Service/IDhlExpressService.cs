using Shiptoboxes.External.DhlExpress.Request;
using Shiptoboxes.External.DhlExpress.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shiptoboxes.External.DhlExpress
{
    public interface IDhlExpressService
    {
        void Configure(DhlExpressServiceConfiguration dhlExpressServiceConfiguration);

        bool VerifyCredentials(string username, string password, string accountNumber);

        Task<CreateShipmentResponse> CreateShipmentRequest(CreateShipmentRequest.Envelope shipmentRequest);

        void GetRateRequest();

        void DeleteShipmentRequet();

        Task<List<DhlTrackingResponse>> GetTrackingDetailsByTrackingNumbers(List<string> trackingNumbers);

    }
}
