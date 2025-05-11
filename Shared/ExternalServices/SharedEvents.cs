

public class SharedEvents
{
    public event Action<int> OnBookingIdClicked;
    
    public void NotifyBookingIdClicked(int bookingId)
    {
        OnBookingIdClicked?.Invoke(bookingId);
    }
}