using Portfolio.Models;

namespace Portfolio.Services;

// In-memory store
public class DemoContactStore : IContactStore
{
    private readonly object _gate = new();
    private readonly List<ContactMessage> _messages = [];
    private int _nextId = 1;

    public void Add(ContactMessage message)
    {
        lock (_gate)
        {
            message.Id = _nextId++;
            message.SentAt = DateTime.Now;
            _messages.Add(message);
        }
    }

    public IReadOnlyList<ContactMessage> GetAll()
    {
        lock (_gate)
            return _messages.ToList();
    }
}
