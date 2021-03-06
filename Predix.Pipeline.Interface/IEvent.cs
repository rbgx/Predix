﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Predix.Domain.Model;
using Predix.Domain.Model.Location;

namespace Predix.Pipeline.Interface
{
    public interface  IEvent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="locationUid">The identifier assigned to this location<example>LOCATION-282</example></param>
        /// <param name="eventType">Filter for pedestrian events<example>["PKIN,PKOUT"]</example></param>
        /// <param name="imageService"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        void GetByLocation(string locationUid, string eventType, IImage imageService, Options options, Customer customer);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bbox"></param>
        /// <param name="eventType1"></param>
        /// <param name="eventType2"></param>
        /// <param name="imageService"></param>
        /// <param name="options"></param>
        /// <param name="customer"></param>
        void GetByBoundaryAsync(string bbox, string eventType1, string eventType2, IImage imageService, Options options, Customer customer);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locationUid"></param>
        /// <param name="eventType"></param>
        /// <param name="epochStartTime"></param>
        /// <param name="epochEndTime"></param>
        /// <returns></returns>
        List<ParkingEvent> Get(string locationUid, string eventType, string epochStartTime, string epochEndTime);
    }
}
