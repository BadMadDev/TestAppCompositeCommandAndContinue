using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using Prism.Commands;

namespace WpfApp5
{
	public class AViewModel
	{
		public AViewModel(MainController controller)
		{
			SaveCommand = new DelegateCommand(Save);
			controller.SaveAndContinueCommand.RegisterCommand(SaveCommand);
		}

		public ICommand SaveCommand { get; }

		private void Save()
		{
			// Everything is fine
		}
	}
}
