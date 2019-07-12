using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;

namespace WpfApp5
{
	public class MainController
	{
		public MainController()
		{
			SaveAndContinueCommand = new ExtendedCompositeCommand(Continue);
		}

		public CompositeCommand SaveAndContinueCommand { get; }

		private void Continue()
		{
			MessageBox.Show("To be continued...");
		}

		private class ExtendedCompositeCommand : CompositeCommand
		{
			private readonly Action _continueAction;

			public ExtendedCompositeCommand(Action continueAction)
			{
				_continueAction = continueAction;
			}

			public override void Execute(object parameter)
			{
				try
				{
					base.Execute(parameter);

					_continueAction?.Invoke();
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					//throw;
				}
			}
		}

	}
}
