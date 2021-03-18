using System.ComponentModel;
using Using_APIs.Services;

namespace Using_APIs.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected IAlertService AlertService { get; }

        protected BaseViewModel(IAlertService alertService)
        {
            AlertService = alertService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
