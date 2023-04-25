using Command.Example.Commands;
using Command.Example.Commands.Abstraction;
using Command.Example.Invoke;
using Command.Example.Invoke.Abstraction;

public class Program
{
    private static void Main()
    {
        var remote = new Remote();
        
        IInvoke invoke = new TV();
        IInvoke volumeInvoke = new Volume();
        ICommand command = new SwitchTvOnCommand(invoke);
        ICommand volumeCommand = new VolumeLevelCommand(volumeInvoke);

        //remote.Command = command;
        //remote.PressButton();
        remote.SetCommand(0, command);
        remote.SetCommand(1, volumeCommand);
        remote.PressButton(0);
        remote.PressButton(1);
        remote.PressButton(1);
        remote.PressButton(1);
        remote.PressButton(1);
        remote.PressButton(1);
        remote.PressUndo();
        remote.PressUndo();
        remote.PressUndo();
        remote.PressUndo();
        remote.PressUndo();

        invoke = new AudioReceiver();
        command = new SwitchOnAudioReceiverCommand(invoke);
        
        //remote.Command = command;
        remote.SetCommand(2, command);
        remote.PressButton(2);
        remote.PressUndo();

        Console.ReadKey();
    }
}