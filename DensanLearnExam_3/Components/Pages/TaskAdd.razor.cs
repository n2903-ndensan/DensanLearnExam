using DensanLearnExam_3.Entities;

namespace DensanLearnExam_3.Components.Pages
{
    public partial class TaskAdd
    {
        private TaskListEntity newTask = new TaskListEntity();

        private List<dynamic> taskStatus = new()
        {
            new { Text = DensanTaskStatus.NotStarted.ToDisplayString(), Value = DensanTaskStatus.NotStarted },
            new { Text = DensanTaskStatus.InProgress.ToDisplayString(), Value = DensanTaskStatus.InProgress },
            new { Text = DensanTaskStatus.Completed.ToDisplayString(), Value = DensanTaskStatus.Completed },
            new { Text = DensanTaskStatus.Ignore.ToDisplayString(), Value = DensanTaskStatus.Ignore }
        };

        private void onSubmit()
        {
            sessionState.State.Add(newTask);
            Navigation.NavigateTo("/task");
        }

        private void Cancel() {
            Navigation.NavigateTo("/task");
        }
    }
}