using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace TrackBallLikeAnnotations
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double selectionStart;
        private double selectionEnd;

        public MainViewModel()
        {
            this.selectionEnd = 1;
            this.selectionStart = 0;
        }

        public List<PlotInfo> Data1 { get; set; }
        public List<PlotInfo> Data2 { get; set; }

        public double SelectionStart
        {
            get { return this.selectionStart; }
            set
            {
                if (this.selectionStart != value)
                {
                    this.selectionStart = value;
                    this.Raise(this.PropertyChanged, "SelectionStart");
                }
            }
        }

        public double SelectionEnd
        {
            get { return this.selectionEnd; }
            set
            {
                if (this.selectionEnd != value)
                {
                    this.selectionEnd = value;
                    this.Raise(this.PropertyChanged, "SelectionEnd");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Raise(PropertyChangedEventHandler handler, string propertyName)
        {
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
