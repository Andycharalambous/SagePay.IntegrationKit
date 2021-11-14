namespace SagePay.IntegrationKit
{
    public enum ProtocolVersion
    {
        [ProtocolVersionAttr("2.23", 233)]
        V_223,
        [ProtocolVersionAttr("3.00", 300)]
        V_300,
        [ProtocolVersionAttr("4.00", 400)]
        V_400
    }
}