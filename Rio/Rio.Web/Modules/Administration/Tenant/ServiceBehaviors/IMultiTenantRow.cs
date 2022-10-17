using Serenity.Data;

namespace Rio
{
    public interface IMultiTenantRow
    {
        Int32Field TenantIdField { get; }
    }
}
