using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonSaze.Domains.Domain.Enums;

namespace BonSaze.Domains.Domain.FinancialCredit
{
    public class CreditRating
    {
        public CreditRating() { }

    public CreditRating(
        Rating rating,
        DateTime creditRatingDate,
        CreditRatingIssueReferenceType creditRatingIssueReference,
        Guid documentId,
        string assetValue,
        DateTime lastAssetValueUpdateDate,
        bool hasOfficialAuditingFirms)
    {
        Rating = rating;
        CreditRatingDate = creditRatingDate;
        CreditRatingIssueReference = creditRatingIssueReference;
        DocumentId = documentId;
        AssetValue = assetValue;
        LastAssetValueUpdateDate = lastAssetValueUpdateDate;
        HasOfficialAuditingFirms = hasOfficialAuditingFirms;
    }

    public Rating Rating { get; set; }
    public DateTime CreditRatingDate { get; set; }
    public CreditRatingIssueReferenceType CreditRatingIssueReference { get; set; }
    public Guid DocumentId { get; set; }
    public string AssetValue { get; set; }
    public DateTime LastAssetValueUpdateDate { get; set; }
    public bool HasOfficialAuditingFirms { get; set; }
    }
}