using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nicholasmarson.github.io_backend.DAOs;





namespace nicholasmarson.github.io_backend;

[Route("api/[controller]")]
[ApiController]
public class GuestBookController : Controller
{
   private readonly GuestBookEntryDAO guestBookEntryDAO;

   public GuestBookController() 
   {
        guestBookEntryDAO = new GuestBookEntryDAO();
   }

    [HttpGet]
    public async Task<IEnumerable<GuestBookEntryDTO>> GetAllGuestBookEntries()
    {
        List<GuestBookEntry> guestBookEntries = await guestBookEntryDAO.GetGuestBookEntries();

        IEnumerable<GuestBookEntryDTO> guestBookEntryDTOs = guestBookEntries.Select(guestBookEntry => new GuestBookEntryDTO
        {
            Id = guestBookEntry.Id,
            Name = guestBookEntry.Name,
            Message = guestBookEntry.Message,
            Date = guestBookEntry.Date
        });

        return guestBookEntryDTOs;
    }
    public async Task<IEnumerable<GuestBookEntryDTO>> GetGuestBookEntriesByName(string name)
    {
        List<GuestBookEntry> guestBookEntries = await guestBookEntryDAO.GetGuestBookEntriesByName(name);

        IEnumerable<GuestBookEntryDTO> guestBookEntryDTOs = guestBookEntries.Select(guestBookEntry => new GuestBookEntryDTO
        {
            Id = guestBookEntry.Id,
            Name = guestBookEntry.Name,
            Message = guestBookEntry.Message,
            Date = guestBookEntry.Date
        });

        return guestBookEntryDTOs;
    }
}
