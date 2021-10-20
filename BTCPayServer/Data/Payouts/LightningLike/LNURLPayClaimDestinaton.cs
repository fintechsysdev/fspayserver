namespace BTCPayServer.Data.Payouts.LightningLike
{
    public class LNURLPayClaimDestinaton : ILightningLikeLikeClaimDestination
    {
        public LNURLPayClaimDestinaton(string lnurl, string nonce)
        {
            LNURL = lnurl;
            Nonce = nonce;
        }

        public string Id => null; //lnurls are reusable
        public decimal? Amount { get; } = null;
        public string LNURL { get; set; }
        public string Nonce { get; set; }

        public override string ToString()
        {
            return $"{LNURL}_{Nonce}";
        }

        public virtual string? ToNormalizedString()
        {
            return LNURL;
        }
    }
}
