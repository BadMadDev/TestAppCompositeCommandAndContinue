using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;

namespace WpfApp5
{
	public class BViewModel
	{
		public BViewModel(MainController controller)
		{
			SaveCommand = new DelegateCommand(Save);
			controller.SaveAndContinueCommand.RegisterCommand(SaveCommand);
		}

		public ICommand SaveCommand { get; }

		private void Save()
		{
			// An error occured?
			if (HasErrors)
				throw new Exception("ERRRRRRRRRRRRRRRRRRRRRRRoooooooooooooooooooRRRRRRRRRRR");
		}

		public bool HasErrors { get; set; }
	}
}
