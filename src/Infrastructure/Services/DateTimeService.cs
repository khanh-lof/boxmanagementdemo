using DemoClean.Application.Common.Interfaces;

namespace DemoClean.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
