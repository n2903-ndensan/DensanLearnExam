using DensanLearnExam_3.Entities;

namespace DensanLearnExam_3.Components.Pages
{
    public partial class TaskList
    {
        private List<TaskListEntity> list = default!;
        bool sessionExsists => sessionState.HasState;

        protected override async Task OnInitializedAsync()
        {
            InitializeTaskList();

            // sessionStateからリストを取得
            list = sessionState.State;

            // リストをソート
            list.Sort();

            await Task.CompletedTask;
        }

        private void NavigateToAddTask()
        {
            Navigation.NavigateTo("/add-task");
        }

        async Task LoadTaskList()
        {
            await Task.Yield();

            if (sessionExsists)
            {
                sessionState.State = list;
                return;
            }
        }

        private void InitializeTaskList()
        {
            List<TaskListEntity> initlist = new List<TaskListEntity>
            {
                new TaskListEntity(DensanTaskStatus.NotStarted, "テスト1", new DateTime(2024, 1, 1), "テスト1の説明"),
                new TaskListEntity(DensanTaskStatus.InProgress, "テスト2", new DateTime(2024, 1, 2), "テスト2の説明"),
                new TaskListEntity(DensanTaskStatus.Completed, "テスト3", new DateTime(2024, 3, 1), "テスト3の説明"),
                new TaskListEntity(DensanTaskStatus.Ignore, "テスト4", new DateTime(2024, 4, 1), "テスト4の説明")
            };

            if (!sessionExsists)
                sessionState.State = initlist;
        }
    }
}
