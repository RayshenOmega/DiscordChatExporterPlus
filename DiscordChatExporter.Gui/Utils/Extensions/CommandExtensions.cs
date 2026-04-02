using System.Windows.Input;

namespace DiscordChatExporter.Gui.Utils.Extensions;

internal static class CommandExtensions
{
    extension(ICommand command)
    {
        public void ExecuteIfCan(object? parameter = null)
        {
            if (command.CanExecute(parameter))
                command.Execute(parameter);
        }
    }
}
