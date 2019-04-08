using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvM
{
    public class MainWindowViewModel :ViewModelBase
    {
        #region Property
        private ObservableCollection<MyData> _PatientList;
        public ObservableCollection<MyData> PatientList { get { return _PatientList; } set { _PatientList = value; OnPropertyChanged("PatientList"); } }

        private string _PatientName;
        public string PatientName { get { return _PatientName; } set { _PatientName = value; OnPropertyChanged("PatientName"); } }

        private string _PatientAddr;
        public string PatientAddr { get { return _PatientAddr; } set { _PatientAddr = value; OnPropertyChanged("PatientAddr"); } }

        private string _PatientAge;
        public string PatientAge { get { return _PatientAge; } set { _PatientAge = value; OnPropertyChanged("PatientAge"); } }
        #endregion


        #region Command
        private ICommand _SearchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if (_SearchCommand == null)
                { _SearchCommand = new RelayCommand(p => this.Search(p)); }
                return _SearchCommand;
            }
        }

        private ICommand _AddCommand;
        public ICommand AddCommand
        {
            get
            {
                if(_AddCommand==null)
                { _AddCommand = new RelayCommand(p => this.Add(p)); }
                return _AddCommand;
            }
        }

        private ICommand _DelCommand;
        public ICommand DelCommand
        {
            get
            {
                if (_DelCommand == null)
                { _DelCommand = new RelayCommand(p => this.Del(p)); }
                return _DelCommand;
            }
        }
        #endregion


        #region Method
        private void Search(object p)
        {
            MyData md = new MyData();
            PatientList = new ObservableCollection<MyData>();

            md.Name = "김김김";
            md.Address = "대한민국";
            md.Age = "111";
            PatientList.Add(md);

            PatientList.Add(new MyData()
            {
                Name = "이름2",
                Address = "주소2",
                Age = "나이2"

            });
        }

        private void Add(object p)
        {
            if (PatientList != null)
            {
                PatientList.Add(new MyData()
                {
                    Name = PatientName,
                    Address = PatientAddr,
                    Age = PatientAge
                });
            }
        }

        private void Del(object p)
        {
            if(p!=null && p is MyData)
            {
                PatientList.Remove(p as MyData);
            }
        }
        #endregion
    }
}
