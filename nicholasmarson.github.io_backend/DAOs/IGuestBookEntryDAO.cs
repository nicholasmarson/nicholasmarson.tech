namespace nicholasmarson.github.io_backend;

public interface IGuestBookEntryDAO
{
    Task<List<GuestBookEntry>> GetGuestBookEntries();
    Task GetGuestBookEntriesByName(string name);
    Task AddGuestBookEntry(GuestBookEntry guestBookEntry);
}
