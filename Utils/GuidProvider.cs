namespace Pupo4ek.Utils;

public class GuidProvider: IGuidProvider
{
    public Guid NewGuid()
    {
        return Guid.NewGuid();
    }
}
