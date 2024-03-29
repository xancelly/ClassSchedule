﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ClassScheduleTestEntities : DbContext
    {
        public ClassScheduleTestEntities()
            : base("name=ClassScheduleTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientDayOfWeek> ClientDayOfWeek { get; set; }
        public virtual DbSet<ClientLesson> ClientLesson { get; set; }
        public virtual DbSet<DayOfWeek> DayOfWeek { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<LanguageLevel> LanguageLevel { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherDayOfWeek> TeacherDayOfWeek { get; set; }
        public virtual DbSet<TrialLesson> TrialLesson { get; set; }
        public virtual DbSet<TypeLesson> TypeLesson { get; set; }
    
        public virtual int GetLesson(Nullable<System.DateTime> date, Nullable<System.TimeSpan> time, Nullable<int> teacher, ObjectParameter idLesson, ObjectParameter count, ObjectParameter lessonTime, ObjectParameter typeLesson, ObjectParameter isPaid, ObjectParameter isAttendance)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var timeParameter = time.HasValue ?
                new ObjectParameter("Time", time) :
                new ObjectParameter("Time", typeof(System.TimeSpan));
    
            var teacherParameter = teacher.HasValue ?
                new ObjectParameter("Teacher", teacher) :
                new ObjectParameter("Teacher", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetLesson", dateParameter, timeParameter, teacherParameter, idLesson, count, lessonTime, typeLesson, isPaid, isAttendance);
        }
    
        public virtual ObjectResult<GetLessonEntities_Result> GetLessonEntities(Nullable<System.DateTime> date, Nullable<System.TimeSpan> time, Nullable<int> teacher)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var timeParameter = time.HasValue ?
                new ObjectParameter("Time", time) :
                new ObjectParameter("Time", typeof(System.TimeSpan));
    
            var teacherParameter = teacher.HasValue ?
                new ObjectParameter("Teacher", teacher) :
                new ObjectParameter("Teacher", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLessonEntities_Result>("GetLessonEntities", dateParameter, timeParameter, teacherParameter);
        }
    }
}
