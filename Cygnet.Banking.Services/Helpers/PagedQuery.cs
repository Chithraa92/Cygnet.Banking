namespace Cygnet.Banking.Services.Helpers
{
    public record PagedQuery
    {
        #region Properties

        public int? PageIndex { get; set; } = 1;
        public int? PageSize { get; set; } = 10;
        public string? SortField { get; set; } = string.Empty;

        #endregion Properties
    }
}