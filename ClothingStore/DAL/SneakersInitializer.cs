﻿using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.DAL
{
    public class SneakersInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SneakersContext>
    {
        protected override void Seed(SneakersContext context)
        {
			var sneakers = new List<Sneakers>
			{
				new Sneakers {id=50, name="AdidasNMD", imageUrl="https://i.ibb.co/0s3pdnc/adidas-nmd.png", price=220},
				new Sneakers {id=51, name="AdidasYeezy", imageUrl="https://i.ibb.co/dJbG1cT/yeezy.png", price=280},
				new Sneakers {id=52, name="BlackConverse", imageUrl="https://i.ibb.co/bPmVXyP/black-converse.png", price=110},
				new Sneakers {id=53, name="NikeWhiteAirForce", imageUrl="https://i.ibb.co/1RcFPk0/white-nike-high-tops.png", price=160},
				new Sneakers {id=54, name="NikeRedHighTops", imageUrl="https://i.ibb.co/QcvzydB/nikes-red.png", price=160},
				new Sneakers {id=55, name="NikeBrownHighTops", imageUrl="https://i.ibb.co/fMTV342/nike-brown.png", price=160},
				new Sneakers {id=56, name="AirJordanLimited", imageUrl="https://i.ibb.co/w4k6Ws9/nike-funky.png", price=190},
				new Sneakers {id=57, name="Timberlands", imageUrl="https://i.ibb.co/Mhh6wBg/timberlands.png", price=200}
			};


			sneakers.ForEach(s => context.SneakerSet.Add(s));
            context.SaveChanges();
        }
    }
}