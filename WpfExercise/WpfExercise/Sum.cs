using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExercise
{
    public class Sum : INotifyPropertyChanged
    {
        private string num1;

        private string num2;

        private string result;

        public string Num1 
        { 
            get
            {
                return num1;
            } 
            set
            {
                if (int.TryParse(value, out int num))
                {
                    num1 = value;
                    OnPropertyChange("Num1");
                    OnPropertyChange("Result");
                }
            }
        }

        public string Num2
        {
            get
            {
                return num2;
            }
            set
            {
                if (int.TryParse(value, out int num))
                {
                    num2 = value;
                    OnPropertyChange("Num2");
                    OnPropertyChange("Result");
                }
            }
        }

        public string Result
        {
            get
            {
                int result = int.Parse(Num1) + int.Parse(Num2);

                return result.ToString();
            }
            set
            {
                int res = int.Parse(Num1) + int.Parse(Num2);

                result = res.ToString();

                OnPropertyChange("Result");
            }
        }               

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
