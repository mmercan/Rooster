using System.ComponentModel;

namespace Rooster.Model.Interfaces
{
    public interface IDirtyCheck : INotifyPropertyChanged
    {
        bool IsDirty { get; set; }

    }
}