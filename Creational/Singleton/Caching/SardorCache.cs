public class SardorCache
{
    private static SardorCache _instance;
    private Dictionary<string, string> _cache;

    private SardorCache()
    {
        _cache = new Dictionary<string, string>();
    }

    public static SardorCache Instance
    {
        get
        {
            if (_instance == null)
                _instance = new SardorCache();
            return _instance;
        }
    }

    public string Get(string key) => _cache[key];

    public void Set(string key, string value) => _cache[key] = value;
}