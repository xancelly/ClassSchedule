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
    
    public partial class TeacherLesson
    {
        public int Id { get; set; }
        public Nullable<int> IdTeacher { get; set; }
        public Nullable<int> IdLesson { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}