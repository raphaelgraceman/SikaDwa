
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SikaDwa.Api.Models;

namespace SikaDwa.Api.Data
{
    public class SikaDwaDbContext : IdentityDbContext<ApplicationUser>
    {
        public SikaDwaDbContext(
            DbContextOptions<SikaDwaDbContext> options)
            : base(options)
        {
        }
    }
}
