﻿using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Exam")]
    [BasedOnRow(typeof(ExamRow), CheckNames = true)]
    public class ExamForm
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalMarks { get; set; }
        public float NegativeMarks { get; set; }
        public short OptionsAvailable { get; set; }
        public string ResultCriteria { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }
    }
}