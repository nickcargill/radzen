

public class SharedEvents
{
    public event Action<int> OnBookingIdClicked;
    public event Action<int> OnIdClickedFromTenantHist;


    public void NotifyBookingIdClicked(int bookingId)
    {
        OnBookingIdClicked?.Invoke(bookingId);
    }

    public void NotifyIdClickedFromTenantHistory(int Id)
    {
        OnIdClickedFromTenantHist?.Invoke(Id);
    }
}