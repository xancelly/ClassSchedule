//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassSchedule.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrialLesson
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> IdLanguageLevel { get; set; }
        public string Comment { get; set; }
        public string Time { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual LanguageLevel LanguageLevel { get; set; }
    }
}