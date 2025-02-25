﻿//using System;
//using System.Collections.Generic;
//using ConFriend.Interfaces;
//using ConFriend.Models;
//using Microsoft.Extensions.Configuration;

//namespace ConFriend.Services
//{
//    public class FloorService : SQLService<Floor>, ICrudService<Floor>
//    {

//        public FloorService(IConfiguration configuration) : base(configuration, "Floor")
//        {

//        }
//        public bool Create(Floor item)
//        {
//            return SQLCommand(SQLType.Create, "n", item.ToSQL());
//        }

//        public List<Floor> GetAll()
//        {
//            SQLCommand(SQLType.GetAll);
//            return Items;
//        }

//        public Floor GetFromId(int id)
//        {
//            SQLCommand(SQLType.GetSingle, $"{Floor.IdentitySQL} {id}");
//            return Item;
//        }

//        public bool Delete(int id)
//        {
//            return SQLCommand(SQLType.Delete, $"{Floor.IdentitySQL} {id}");
//        }

//        public bool Update(Floor item)
//        {
//            return SQLCommand(SQLType.Update, item.Identity(), item.ToSQL());
//        }

//        public List<Floor> GetFiltered(string filter, ICrudService<Floor>.FilterType filterType)
//        {
//            return null;
//        }
//        public override Floor OnRead()
//        {
//            Floor floor = new Floor();

//            floor.FloorId = Reader.GetInt32(0);
//            floor.VenueId = Reader.GetInt32(1);
//            floor.Name = Reader.GetString(2);
//            floor.Image = Reader.IsDBNull(3) ? "" : Reader.GetString(3);

//            return floor;
//        }
//    }
//}
