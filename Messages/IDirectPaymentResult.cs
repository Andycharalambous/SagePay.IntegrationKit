namespace SagePay.IntegrationKit.Messages
{
    public interface IDirectPaymentResult : ICaptureResult
    {
        string Cavv { get; set; }
        ThreeDSecureStatus ThreeDSecureStatus { get; set; }
        string Md { get; set; }
        string AcsUrl { get; set; }
        string PaReq { get; set; }
        string PayPalRedirectUrl { get; set; }
        
        // 3DSv2
        string CReq { get; set; }
        string ACSTransID { get; set; }
        string DSTransID { get; set; }
        string SchemeTraceID { get; set; }
    }
}