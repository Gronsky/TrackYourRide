using System;
using System.Threading.Tasks;

namespace TrackYourRide.Core.Services
{
    public interface ITrackService
    {
        public Task GetCurrentLocation();
    }
}
