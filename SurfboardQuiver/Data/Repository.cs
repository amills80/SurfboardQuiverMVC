using SurfboardQuiver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfboardQuiver.Data
{
    public class Repository
    {
        public static Surfboard[] _surfboards = new Surfboard[]
        {
            new Surfboard()
            {
                Id = 1,
                Make = new Builder()
                {
                    Name = "Las Olas"
                },
                Model = "Plover",
                Length = 7.1f,
                Width = 22.4f,
                Shape = "MidLength",
                FinSetup = "2+1",
                Description = "The Plover is a mid length hull designed for small, fun, summer waves.  This board has a fully rolled bottom contour which transitions to a paneled vee out of the tail.  This board is designed to turn and trim in waves from knee to head high and excels in clean, point surf.",
                Rating = 4f,
            },
            new Surfboard()
            {
                Id = 2,
                Make = new Builder()
                {
                    Name = "Ghetto"
                },
                Model = "Fuggly Model",
                Length = 9.7f,
                Width = 23.5f,
                Shape = "Longboard",
                FinSetup = "Single", 
                Description = "Traditional noseriding log. Will treat you right on those near flat (to chest high) beach breaks.",
                Rating = 4.2f,
            },
            new Surfboard()
            {
                Id = 3,
                Make = new Builder()
                {
                    Name = "Mayo",
                },
                Model = "Twin Keel",
                Length = 6.3f,
                Width = 22.5f,
                Shape = "Fish",
                FinSetup = "Twin", 
                Description = "A loose and speedy ride.  Pairs well with soft faced waves and groundswell.",
                Rating = 4.1f,
            },
        };

        public Surfboard GetSurfboard(int id)
        {
            var detailBoard = new Surfboard();
            foreach (var surfboard in _surfboards)
            {
                if (surfboard.Id == id)
                {
                    detailBoard = surfboard;
                    break;
                }
            }
            return detailBoard;
        }

        public Surfboard[] GetSurfboards()
        {
            return _surfboards;
        }
    }
}