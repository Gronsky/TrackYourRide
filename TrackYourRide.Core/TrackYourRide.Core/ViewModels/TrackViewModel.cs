using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using TrackYourRide.Core.Services;

namespace TrackYourRide.Core.ViewModels
{
    public class TrackViewModel : MvxViewModel
    {
        readonly ITrackService _trackService;
        private string _time;
        private string _avgSpeed;
        private string _distance;

        public string Time
        {
            get => _time;
            private set => SetProperty(ref _time, value);
        }
        public string AvgSpeed
        {
            get => _avgSpeed;
            private set => SetProperty(ref _avgSpeed, value);
        }
        public string Distance
        {
            get => _distance;
            private set => SetProperty(ref _distance, value);
        }
        public IMvxCommand StartCommand { get; private set; }

        public TrackViewModel(ITrackService trackService)
        {
            _trackService = trackService;

            Time = new string("00:00:00");
            AvgSpeed = new string("0.0");
            Distance = new string("0.0");
            StartCommand = new MvxCommand(StartTrack);
        }

        private void StartTrack()
        {
            Time = new string("00:00:18");
            AvgSpeed = new string("0.1");
            Distance = new string("0.1");
        }
    }
}
