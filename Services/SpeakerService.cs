﻿using System;
using System.Collections.Generic;
using ConFriend.Interfaces;
using ConFriend.Models;
using Microsoft.Extensions.Configuration;

namespace ConFriend.Services
{
    public class SpeakerService : SQLService<Speaker>, ICrudService<Speaker>
    {

        public SpeakerService(IConfiguration configuration) : base(configuration, "Speaker")
        {

        }

        public bool Create(Speaker item)
        {
            throw new NotImplementedException();
        }

        public List<Speaker> GetAll()
        {
            SQLCommand(SQLType.GetAll);
            return Items;
        }

        public Speaker GetFromId(int id)
        {
            SQLCommand(SQLType.GetSingle, id.ToString());
            return Item;
        }

        public bool Delete(int id)
        {
           return SQLCommand(SQLType.Delete, id.ToString());
        }

        public bool Update(Speaker item)
        {
            throw new NotImplementedException();
        }

        public List<Speaker> GetFiltered(string filter, ICrudService<Speaker>.FilterType filterType)
        {
            throw new NotImplementedException();
        }

        public override Speaker OnRead()
        {
            Speaker speaker = new Speaker();

            speaker.SpeakerId = Reader.GetInt32(0);
            speaker.FirstName = Reader.GetString(1);
            speaker.LastName = Reader.GetString(2);
            speaker.Email = Reader.GetString(3);
            speaker.Image = Reader.GetString(4);
            speaker.Description = Reader.GetString(5);
            speaker.Title = Reader.GetString(6);

            return speaker;
        }
    }
}
