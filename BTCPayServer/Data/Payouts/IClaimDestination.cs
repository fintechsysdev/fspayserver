#nullable enable
using NBitcoin;

namespace BTCPayServer.Data
{
    public interface IClaimDestination
    {
        public string? Id { get; }
        decimal? Amount { get; }

        public virtual string? ToNormalizedString()
        {
            return ToString();
        }
    }
}
