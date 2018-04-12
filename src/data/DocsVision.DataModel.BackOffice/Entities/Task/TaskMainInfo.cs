using System;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class TaskMainInfo : BaseCardSectionRow
	{
		public string Name { get; set; }

		public string Content { get; set; }

		public Guid? AuthorID { get; set; } // Author

		public DateTime? StartDate { get; set; }

		public DateTime? EndDate { get; set; }

		public DateTime? StartDateActual { get; set; }

		public DateTime? EndDateActual { get; set; }

		public int? Laboriousness { get; set; }

		public int? LaboriousnessActual { get; set; }

		public int? Reminder { get; set; }

		public DateTime? ReminderDate { get; set; }

		public bool? ForManager { get; set; }

		public Guid? ParentTaskID { get; set; } // ParentTask

		public Guid? ChildTaskList { get; set; }

		public Guid? CompletedUserID { get; set; } // CompletedUser

		public Guid? RejectedUserID { get; set; } // RejectedUser

		public string Report { get; set; }

		public bool? IsOverdue { get; set; }

		public int? PercentCompleted { get; set; }

		public int? DurationActual { get; set; }

		public bool? OnControl { get; set; }

		public Guid? ControllerID { get; set; } // Controller

		public DateTime? ControllerDate { get; set; }

		public bool? RequiresAcceptance { get; set; }

		public bool? ExecutionStopped { get; set; }

		public DateTime? StartDateBeforePostponement { get; set; }

		public DateTime? EndDateBeforePostponement { get; set; }

		public int? PostponementCount { get; set; }

		public TaskPriority? Priority { get; set; }

		public DateTime? StartTaskDate { get; set; }

		public virtual StaffEmployee Author { get; set; }

		public virtual StaffEmployee CompletedUser { get; set; }

		public virtual StaffEmployee RejectedUser { get; set; }

		public virtual StaffEmployee Controller { get; set; }

		public virtual Task ParentTask { get; set; }
	}
}