using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("CouponCodes")]
    [DisplayName("Coupon Code"), InstanceName("Coupon Code")]
    [ReadPermission(PermissionKeys.ExamListManagement.View)]
    [ModifyPermission(PermissionKeys.ExamListManagement.Modify)]
    public sealed class CouponCodeRow : LoggingRow<CouponCodeRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Code"), NotNull, QuickSearch, NameProperty]
        public string Code
        {
            get => fields.Code[this];
            set => fields.Code[this] = value;
        }

        [DisplayName("Exam List"), NotNull, ForeignKey("ExamLists", "Id"), LeftJoin("jExamList"), TextualField("ExamListName")]
        [LookupEditor("Workspace.ExamList")]
        public int? ExamListId
        {
            get => fields.ExamListId[this];
            set => fields.ExamListId[this] = value;
        }

        [DisplayName("Validity Type"), NotNull]
        public EValidityType? ValidityType
        {
            get => (EValidityType?)fields.ValidityType[this];
            set => fields.ValidityType[this] = (short?)value;
        }

        [DisplayName("Count Type")]
        public ECountType? CountType
        {
            get => (ECountType?)fields.CountType[this];
            set => fields.CountType[this] = (short?)value;
        }

        [DisplayName("Count")]
        public int? Count
        {
            get => fields.Count[this];
            set => fields.Count[this] = value;
        }

        [DisplayName("Validity In Days")]
        public int? ValidityInDays
        {
            get => fields.ValidityInDays[this];
            set => fields.ValidityInDays[this] = value;
        }

        [DisplayName("Valid Date")]
        public DateTime? ValidDate
        {
            get => fields.ValidDate[this];
            set => fields.ValidDate[this] = value;
        }

        [DisplayName("Consumed Count")]
        public int? ConsumedCount
        {
            get => fields.ConsumedCount[this];
            set => fields.ConsumedCount[this] = value;
        }

        [DisplayName("Coupon Validity Date")]
        public DateTime? CouponValidityDate
        {
            get => fields.CouponValidityDate[this];
            set => fields.CouponValidityDate[this] = value;
        }

        [DisplayName("Is Active"), DefaultValue(1)]
        public int? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Exam List Name"), Expression("jExamList.[Name]")]
        public string ExamListName
        {
            get => fields.ExamListName[this];
            set => fields.ExamListName[this] = value;
        }

        [DisplayName("Exam List Description"), Expression("jExamList.[Description]")]
        public string ExamListDescription
        {
            get => fields.ExamListDescription[this];
            set => fields.ExamListDescription[this] = value;
        }

        [DisplayName("Exam List Insert Date"), Expression("jExamList.[InsertDate]")]
        public DateTime? ExamListInsertDate
        {
            get => fields.ExamListInsertDate[this];
            set => fields.ExamListInsertDate[this] = value;
        }

        [DisplayName("Exam List Insert User Id"), Expression("jExamList.[InsertUserId]")]
        public int? ExamListInsertUserId
        {
            get => fields.ExamListInsertUserId[this];
            set => fields.ExamListInsertUserId[this] = value;
        }

        [DisplayName("Exam List Update Date"), Expression("jExamList.[UpdateDate]")]
        public DateTime? ExamListUpdateDate
        {
            get => fields.ExamListUpdateDate[this];
            set => fields.ExamListUpdateDate[this] = value;
        }

        [DisplayName("Exam List Update User Id"), Expression("jExamList.[UpdateUserId]")]
        public int? ExamListUpdateUserId
        {
            get => fields.ExamListUpdateUserId[this];
            set => fields.ExamListUpdateUserId[this] = value;
        }

        [DisplayName("Exam List Is Active"), Expression("jExamList.[IsActive]")]
        public int? ExamListIsActive
        {
            get => fields.ExamListIsActive[this];
            set => fields.ExamListIsActive[this] = value;
        }

        [DisplayName("Exam List Tenant Id"), Expression("jExamList.[TenantId]")]
        public int? ExamListTenantId
        {
            get => fields.ExamListTenantId[this];
            set => fields.ExamListTenantId[this] = value;
        }

        public CouponCodeRow()
            : base()
        {
        }

        public CouponCodeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields :LoggingRowFields
        {
            public Int32Field Id;
            public StringField Code;
            public Int32Field ExamListId;
            public Int32Field ValidityType;
            public Int32Field CountType;
            public Int32Field Count;
            public Int32Field ValidityInDays;
            public DateTimeField ValidDate;
            public Int32Field ConsumedCount;
            public DateTimeField CouponValidityDate;
           
            public Int32Field IsActive;

            public StringField ExamListName;
            public StringField ExamListDescription;
            public DateTimeField ExamListInsertDate;
            public Int32Field ExamListInsertUserId;
            public DateTimeField ExamListUpdateDate;
            public Int32Field ExamListUpdateUserId;
            public Int32Field ExamListIsActive;
            public Int32Field ExamListTenantId;
        }
    }
}