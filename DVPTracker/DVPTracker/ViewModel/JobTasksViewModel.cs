using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DVPTracker.ViewModels
{
    public class JobTasksViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TaskModel> Tasks { get; set; }

        public JobTasksViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>
        {
            new TaskModel
            {
                Title = "Evening Check rate and Maint Check",
                Description = "at 6PM",
                IsCompleted = false,
            },
            new TaskModel
            {
                Title = "NIS Batch check",
                Description = "at 7PM",
                IsCompleted = true,
            }
            ,
            new TaskModel
            {
                Title = "TVM batch check",
                Description = "at 11PM",
                IsCompleted = false,
            }

            ,
            new TaskModel
            {
                Title = "OMR batch check",
                Description = "at 11PM",
                IsCompleted = true,
            }

            ,
            new TaskModel
            {
                Title = "Rollover check",
                Description = "at 1PM",
                IsCompleted = true,
            },
            new TaskModel
            {
                Title = "Feed verification",
                Description = "at 2AM",
                IsCompleted = true,
            },
            new TaskModel
            {
                Title = "Pearl Morning batch check",
                Description = "at 3AM",
                IsCompleted = true,
            },
            new TaskModel
            {
                Title = "MC Morning batch check",
                Description = "at 5AM",
                IsCompleted = true,
            },
            new TaskModel
            {
                Title = "DVP Morning batch check",
                Description = "at 8AM",
                IsCompleted = true,
            },
            new TaskModel
            {
                Title = "DVP val and reports",
                Description = "at 10AM",
                IsCompleted = true,
            },
            new TaskModel
            {
                Title = "TRM check",
                Description = "at 10.30AM",
                IsCompleted = true,
            },
            new TaskModel
            {
                Title = "Afternoon val and catchup",
                Description = "at 3PM",
                IsCompleted = true,
            }
        };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class JobTask
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class CommentModel
    {
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public string User { get; set; }
    }
}
