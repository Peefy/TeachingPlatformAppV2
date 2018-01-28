﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

using TeachingPlatformApp.Models;
using TeachingPlatformApp.Utils;

namespace TeachingPlatformApp.Models
{
    public class FlighterModel : WswBaseModel
    {
        public FlighterModel()
        {           
            this.Angle = Config.MyFlighterInfo.InitYaw;
            this.IsNotOutofRoute = false;
            this.MyMapPosition = new Point()
            {
                X = Config.MyFlighterInfo.InitMyPointX,
                Y = Config.MyFlighterInfo.InitMyPointY
            };
            this.Name = Config.StringResource.FlighterName;
            this.WswAngleWithLocation = Config.WswData.FlighterInitInfo;
            this.IsJudgeRoute = Config.TestTrailRouteConfig.OutOfRouteTestSwitch == 0 ||
                Config.TestTrailRouteConfig.OutOfRouteTestSwitch >= 2;
        }

        public override string MyMapInfoToString()
        {
            return base.MyMapInfoToString() + (IsJudgeRoute == true ? $"通过航路点数：{NowSetPointsIndex}" : "");
        }

    }

}
