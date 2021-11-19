using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LNStone.Models;

namespace LNStone.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action DoWork;

        private StoneDTO stoneDTO;

        public RelayCommand(Action work)
        {
            DoWork = work;
        }

        public RelayCommand(StoneDTO stoneDTO)
        {
            this.stoneDTO = stoneDTO;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoWork();
        }
    }
}
