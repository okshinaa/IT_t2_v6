using WpfApplicationAnimals.Models;

namespace WpfApplicationAnimals.ViewModels;

public class PantherViewModel : AnimalViewModel
{
    public event EventHandler<EventArgs> VoiceEvent;

    public PantherViewModel() : base(new Panther())
    {
    }
    
    public PantherViewModel(Panther panther) : base(panther)
    {
        panther.VoiceEvent += (sender, args) => VoiceEvent?.Invoke(sender, args);
    }

    public bool ClimbTree()
    {
        return ((Panther)_animal).ClimbTree();
    }

    public void MakeVoice()
    {
        ((Panther)_animal).MakeVoice();
        AnimalSound = "Ррррр";
    }
}