﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewServer_V2.Models
{
    public class ParkingDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=parking.db");
        }
        public DbSet<Place> Places { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
    public class Floor
    {
        public int FloorId { get; set; }
        public int NFloor { get; set; }
        public ICollection<Place> Places { get; set; }
    }
    public class Place
    {
        public int PlaceId { get; set; }
        public Floor Floor { get; set; }
        public ICollection<Car> Records { get; set; }
        public bool State { get; set; }
    }
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Owner { get; set; }
        public Place Place { get; set; }
        public DateTime Input { get; set; }
        public DateTime Output { get; set; }
    }
}
