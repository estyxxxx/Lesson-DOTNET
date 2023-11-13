using api_model;

namespace api_service
{
    public interface data
    {
        //public static List<Missile> data = new List<Missile>();
        IEnumerable<Missile> list { get; }

        string[] print();
    }
}
