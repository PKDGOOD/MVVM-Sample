using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvM
{
    public class EntityBase : INotifyPropertyChanged, INotifyPropertyChanging
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Occurs when a property value is changed.
        /// </summary>
        /// <param name="propertyName"></param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region INotifyPropertyChanging
        public event PropertyChangingEventHandler PropertyChanging;
        /// <summary>
        /// Occurs when a property value is changing.
        /// </summary>
        /// <param name="propertyName"></param>
        public virtual void OnPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }
        #endregion
    }
}
