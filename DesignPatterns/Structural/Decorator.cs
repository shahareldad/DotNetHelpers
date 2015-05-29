using System;

namespace ConsoleProject.Structural
{
    public class DateTimeProviderDecrator
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public DateTimeProviderDecrator(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public string GetDateTimeString()
        {
            return _dateTimeProvider.GetDateTimeString() + " " + DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }

    public interface IDateTimeProvider
    {
        string GetDateTimeString();
    }

    public class DateTimeProvider : IDateTimeProvider
    {
        public string GetDateTimeString()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
