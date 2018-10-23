using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class DeviceInfoModel
    {
        #region 主機
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string Vision { get; set; }
        public int StationNumber { get; set; }
        public int MacAddress { get; set; }
        #endregion
        #region 程式
        public int ProgramSize { get; set; }
        public string LockStatus { get; set; }
        #endregion
        #region 掃描時間
        public double CurrentTime { get; set; }
        public double ShortestTime { get; set; }
        public double LongestTime { get; set; }
        #endregion
    }
}
