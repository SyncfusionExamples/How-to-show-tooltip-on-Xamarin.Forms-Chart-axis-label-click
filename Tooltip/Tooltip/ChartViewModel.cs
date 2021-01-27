using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Tooltip
{
    public class ChartViewModel
    {
        public ObservableCollection<ChartModel> ColumnData { get; set; }

        public ChartViewModel()
        {
            ColumnData = new ObservableCollection<ChartModel>
            {
                new ChartModel("Ford", 55),
                new ChartModel("BMW", 88),
                new ChartModel("Audi", 70),
                new ChartModel("Mercedes", 75),
                new ChartModel("Datsun", 65),
            };
        }
    }

    public class ChartModel : INotifyPropertyChanged
    {
        private string xValue;
        public string XValue
        {
            get
            {
                return xValue;
            }

            set
            {
                if (value != xValue)
                {
                    xValue = value;
                    OnPropertyChanged("XValue");
                }
            }
        }

        private double yValue;
        public double YValue
        {
            get
            {
                return yValue;
            }

            set
            {
                if (value != yValue)
                {
                    yValue = value;
                    OnPropertyChanged("YValue");
                }
            }
        }

        public ChartModel(string xVal, double yVal)
        {
            XValue = xVal;
            YValue = yVal;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
