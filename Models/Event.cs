﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace ConFriend.Models
{
    public class Event : IModel
    {
        public int EventId { get; set; }
        public int? SpeakerId { get; set; }
        public int? RoomId { get; set; }
        public int? ConferenceId { get; set; }
        public string Name { get; set; }

        //public Speaker Host { get; set; }
        public DateTime? StartTime { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTime? EndTime => StartTime + Duration;

        //public int DurationInMinutes { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        //public Room Room { get; set; }
        //public Conference Conference { get; set; }
        public int? Capacity { get; set; }
        /// <summary>
        /// Nice to have ville være ideel til kø kontrol
        /// </summary>
        public LinkedList<User> Users { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public string Image { get; set; }
        public bool Hidden { get; set; }
        public bool Cancelled { get; set; }
        public bool RoomHidden { get; set; }
        public bool RoomCancelled { get; set; }
        public Dictionary<string, int> SeatCategoriesTaken { get; set; }
        public List<string> Themes { get; set; }

        
        public string ToSQL()
        {
           // string pased = Description.Replace(",","*%[]*")
            CultureInfo culture = new CultureInfo("en-US");
            return $"SpeakerId = {SpeakerId}, RoomId = {RoomId}, ConferenceId = {ConferenceId}, Name = '{Name}'," +
                   $" StartTime = '{StartTime?.ToString(culture)}', Duration = {Duration?.TotalMinutes}," +
                   $" Type = '{Type}', Description = '{Description}', Capacity = {Capacity}, ImageUrl = '{Image}'," +
                   $" Hidden = '{Hidden}', Cancelled = '{Cancelled}', RoomHidden = '{RoomHidden}'," +
                   $" RoomCancelled = '{RoomCancelled}'";
        }

        public string Identity()
        {
            return $"EventId = {EventId}";
        }

        ModelTypes DataType
        {
            get
            {
                return ModelTypes.Event;
            }

        }

    }
}
