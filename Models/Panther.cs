namespace WpfApplicationAnimals.Models;

public class Panther : Animal
{
    public event EventHandler<EventArgs> VoiceEvent;
    
    public bool ClimbTree()
    {
        return true;
    }

    public override void Move()
    {
        Speed = Math.Min(Speed + 50, 300);
    }

    public override void Stand()
    {
        Speed = Math.Max(Speed - 50, 0);
    }

    public void MakeVoice()
    {
        VoiceEvent?.Invoke(this, EventArgs.Empty);
    }
}