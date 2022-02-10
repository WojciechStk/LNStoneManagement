using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LNStone.Views;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Runtime.Remoting.Contexts;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace LNStone.ViewModels
{
    class GalleryViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal class Command : ICommand
        {

            Action<object> executeMethod;
            Func<object, bool> canexecuteMethod;

            public Command(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
            {
                this.executeMethod = executeMethod;
                this.canexecuteMethod = canexecuteMethod;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                executeMethod(parameter);
            }

            public event EventHandler CanExecuteChanged;
        }


        public ICommand GoBackCommand { get; set; }
        public ICommand GoNextCommand { get; set; }
        int i = 1;
        //private object picHolder { get; set; }
        public ImageSource Source { get; set; }

        

        public GalleryViewModel()
        {

            //GoBackCommand = new Command(GoBack, CanExecuteMethod);
            GoNextCommand = new Command(GoNext, CanExecuteMethod);
        }


        //public string DisplayedImagePath
        //{
        //    get { return "/LNStone;component/Images/1.jpg"; }
          
            
        //}

        private ImageSource _PlayPauseImg;
        public ImageSource PlayPauseImg
        {
            get
            {
                return new BitmapImage(new Uri(@"/LNStone;component/Images /1.jpg", UriKind.Relative));
            }
            set
            {
                if (value != null)
                {
                    PlayPauseImg = new BitmapImage(new Uri(@"/LNStone;component/Images/" + i + ".jpg", UriKind.Relative));
                    OnPropertyChanged("GoBack");
                }
                else if (value == null)
                {
                    PlayPauseImg = new BitmapImage(new Uri(@"/LNStone;component/Images /1.jpg", UriKind.Relative));
                }
            }
        }

        //private void GoBack()
        //{
        //    i--;

        //    if (i < 1)
        //    {
        //        i = 20;
        //    }

        //    Source = new BitmapImage(new Uri(@"/LNStone;component/Images/" + i + ".jpg", UriKind.Relative));
        //    OnPropertyChanged("GoBack");
        //}



        private void GoNext(object parameter)
        {
            i++;

            if (i > 20)
            {
                i = 1;
            }
            Source = new BitmapImage(new Uri(@"/LNStone;component/Images/" + i + ".jpg", UriKind.Relative));
            OnPropertyChanged("GoNext");
        }

        private bool CanExecuteMethod(object parameter)
        {
            return true;
        }

        
    }
}
