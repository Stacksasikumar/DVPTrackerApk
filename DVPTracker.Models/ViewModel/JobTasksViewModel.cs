using System.Collections.ObjectModel;
using System.ComponentModel;
using DVPTracker.Models;

namespace DVPTracker.ViewModels
{
    public class JobTasksViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<JobTask> JobTasks { get; set; }

        public JobTasksViewModel()
        {
            JobTasks = new ObservableCollection<JobTask>
            {
                new JobTask { Name = "Task 1", Description = "Description for Task 1" },
                new JobTask { Name = "Task 2", Description = "Description for Task 2" },
                // Add more tasks here
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
