namespace DensanLearnExam_3.Entities
{
    public class TaskListEntity : IComparable<TaskListEntity>
    {
        public DensanTaskStatus Status { get; set;}
        public string Title { get; set;}
        public DateTime DeadLine { get; set;}
        public string Description { get; set;}

        public TaskListEntity() {
            
        }

        public TaskListEntity(DensanTaskStatus status, string title, DateTime deadLine, string description)
        {
            Status = status;
            Title = title;
            DeadLine = deadLine;
            Description = description;
        }

        public int CompareTo(TaskListEntity? other)
        {
            if (other == null) return 1;

            // まずStatusで比較し、同じ場合はDeadLineで比較
            int statusComparison = this.Status.CompareTo(other.Status);
            if (statusComparison != 0)
            {
                return statusComparison;
            }
            return this.DeadLine.CompareTo(other.DeadLine);
        }

        public string getFirstLine()
        {
            return Description.Split('\n')[0];
        }
    }
    public enum DensanTaskStatus
    {
        NotStarted = 0,
        InProgress = 1,
        Completed = 2,
        Ignore = 9
    }

    public static class TaskStatusExtensions
    {
        public static string ToDisplayString(this DensanTaskStatus status)
        {
            return status switch
            {
                DensanTaskStatus.NotStarted => "未着手",
                DensanTaskStatus.InProgress => "仕掛中",
                DensanTaskStatus.Completed => "完了",
                DensanTaskStatus.Ignore => "無視",
                _ => "不明"
            };
        }
    }
}
