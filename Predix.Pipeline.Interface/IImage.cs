﻿using Predix.Domain.Model.Location;

namespace Predix.Pipeline.Interface
{
    public interface IImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parkingEvent"></param>
        /// <param name="imageAssetUid"></param>
        /// <param name="timestamp"></param>
        /// <returns>Base64 Image</returns>
        void MediaOnDemand(ParkingEvent parkingEvent, string imageAssetUid, string timestamp);
    }
}
