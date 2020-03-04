using MediTest.Application.Common.Interfaces;
using System;

namespace MediTest.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
