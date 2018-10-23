using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;
//git
namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        #region Fields
        private string _deviceType;
        private string _deviceName;
        private string _Vision;
        private int _stationNumber;
        private int _macAddress;
        private int _programSize;
        private string _lockStatus;
        private double _currentTime;
        private double _shortestTime;
        private double _longestTime;

        private BindableCollection<DeviceInfoModel> _deviceInfo = new BindableCollection<DeviceInfoModel>();
        #endregion
        #region Property
        public string DeviceType {
            get
            {
                return _deviceType;
            }
            set
            {
                _deviceType = value;
                NotifyOfPropertyChange(() => DeviceType);
            }
        }
        public string DeviceName {
            get
            {
                return _deviceName;
            }
            set
            {
                _deviceName = value;
                NotifyOfPropertyChange(() => DeviceName);
            }
        }
        public string Vision
        {
            get
            {
                return _Vision;
            }
            set
            {
                _Vision = value;
                NotifyOfPropertyChange(() => Vision);
            }
        }
        public int StationNumber
        {
            get
            {
                return _stationNumber;
            }
            set
            {
                _stationNumber = value;
                NotifyOfPropertyChange(() => StationNumber);
            }
                 }
        public int MacAddress
        {
            get
            {
                return _macAddress;
            }
            set
            {
                _macAddress = value;
                NotifyOfPropertyChange(() => MacAddress);
            }
        }
        public int ProgramSize
        {
            get
            {
                return _programSize;
            }
            set
            {
                _programSize = value;
                NotifyOfPropertyChange(() => ProgramSize);
            }
        }
        public string LockStatus
        {
            get
            {
                return _lockStatus;
            }
            set
            {
                _lockStatus = value;
                NotifyOfPropertyChange(() => LockStatus);
            }
        }
        public double CurrentTime
        {
            get
            {
                return _currentTime;
            }
            set
            {
                _currentTime = value;
                NotifyOfPropertyChange(() => CurrentTime);
            }
        }
        public double ShortestTime
        {
            get
            {
                return _shortestTime;
            }
            set
            {
                _shortestTime = value;
                NotifyOfPropertyChange(() => ShortestTime);
            }
        }
        public double LongestTime
        {
            get
            {
                return _longestTime;
            }
            set
            {
                _longestTime = value;
                NotifyOfPropertyChange(() => LongestTime);
            }
        }
        public BindableCollection<DeviceInfoModel> DeviceInfo
        {
            get { return _deviceInfo; }
            set
            {
                _deviceInfo = value;
                NotifyOfPropertyChange(() => DeviceInfo);
            }
        }
        #endregion
        public ShellViewModel()
        {
           
        }
        //git
        public void LoadDeviceInfo() {

            DeviceType = "AS300_SIMULATOR";
            DeviceName = "AS300_PSJ_0";
            Vision = "V1.04.10";
            StationNumber = 1;
            MacAddress = 1;
            ProgramSize = 131056;
            LockStatus = "未上鎖";
            CurrentTime = 0.100;
            ShortestTime = 0.100;
            LongestTime = 0.100;
                
            DeviceInfo.Add(new DeviceInfoModel
            {
                DeviceType = "AS300_SIMULATOR",
                DeviceName = "AS300_PSJ_0",
                Vision = "V1.04.10",
                StationNumber = 1,
                MacAddress = 1,
                ProgramSize = 131056,
                LockStatus = "未上鎖",
                CurrentTime = 0.100,
                ShortestTime = 0.100,
                LongestTime = 0.100
            });
            NotifyOfPropertyChange(() => DeviceInfo);
        }





    }
}
