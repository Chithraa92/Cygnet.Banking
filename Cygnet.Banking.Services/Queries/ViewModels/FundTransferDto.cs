using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cygnet.Banking.Services.Queries.ViewModels
{
    public record FundTransferDto
    {
        public string? Id { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public string? AccountId { get; set; }
        public string? FromAccount { get; set; }
        public string? BenificiaryName { get; set; }
        public string? BenificiaryAccountNumber { get; set; }
        public string? BenificiaryIFSCCode { get; set; }
        public string? BenificiaryAccountType { get; set; }
        public string? StatusSentTo { get; set; }
        public string? AccountType { get; set; }
        public string? Source { get; set; }
        public string? SenderName { get; set; }
        public string? RecipientName { get; set; }
        public string? Destination { get; set; }
        public string? ReferenceNumber { get; set; }
        
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public string Id { get; set; }

        //[MaxLength(ModelConstants.MoneyTransfer.DescriptionMaxLength)]
        //public string Description { get; set; }

        //[Required]
        //public decimal Amount { get; set; }

        //[Required]
        //public DateTime MadeOn { get; set; }

        //[Required]
        //public string AccountId { get; set; }

        //public string Account { get; set; }

        //[Required]
        //[MaxLength(ModelConstants.BankAccount.UniqueIdMaxLength)]
        //public string Source { get; set; }

        //[Required]
        //[MaxLength(ModelConstants.User.FullNameMaxLength)]
        //public string SenderName { get; set; }

        //[Required]
        //[MaxLength(ModelConstants.User.FullNameMaxLength)]
        //public string RecipientName { get; set; }

        //[Required]
        //[MaxLength(ModelConstants.BankAccount.UniqueIdMaxLength)]
        //public string Destination { get; set; }

        //[Required]
        //public string ReferenceNumber { get; set; }
    }
}
