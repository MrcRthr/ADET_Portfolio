using Portfolio.Models;

namespace Portfolio.Services;

public interface IContactStore
{
    void Add(ContactMessage message);
    IReadOnlyList<ContactMessage> GetAll();
}
