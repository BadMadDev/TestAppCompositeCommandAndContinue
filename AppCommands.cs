using Prism.Commands;

namespace WpfApp5
{
	public static class AppCommands
	{
		private static CompositeCommand _saveCommand = new CompositeCommand();

		public static CompositeCommand SaveCommand
		{
			get => _saveCommand;
			set => _saveCommand = value;
		}
	}

	public class AppCommandProxy
	{
		virtual public CompositeCommand SaveCommand => AppCommands.SaveCommand;
	}
}
