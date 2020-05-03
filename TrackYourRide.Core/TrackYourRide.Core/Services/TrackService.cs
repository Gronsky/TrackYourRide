using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace TrackYourRide.Core.Services
{
    public class TrackService : ITrackService
    {
        private Location _currentLocation;

        public TrackService()
        {
        }

        public async Task GetCurrentLocation()
        {
            try
            {
                _currentLocation = await Geolocation.GetLastKnownLocationAsync();

                if (_currentLocation != null)
                {
                    Console.WriteLine($"\n\nLatitude: {_currentLocation.Latitude}, " +
                                        $"\nLongitude: {_currentLocation.Longitude}, " +
                                        $"\nAltitude: {_currentLocation.Altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
        
        private double GetDistanceTo(Location destination)
        {
            var kilometers = Location.CalculateDistance(destination, _currentLocation, DistanceUnits.Kilometers);
            return kilometers;
        }
    }
}
