namespace Pupo4ek.Utils;

public interface IDateProvider
{
    public DateTime Now();
    public DateTime UtcNow();
    public DateTime Today();
}
