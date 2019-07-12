using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp5
{
	public class MainWindowViewModel
	{
		public MainWindowViewModel(MainController controller)
		{
			SaveCommand = controller.SaveAndContinueCommand;
		}

		public ICommand SaveCommand { get; }
	}
}
