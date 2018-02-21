using SurfboardQuiver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfboardQuiver.Data
{
    public class Repository
    {
        /// <summary>
        /// Seed data installation
        /// </summary>
        public static List<Surfboard> _surfboards = new List<Surfboard>()
        {
            new Surfboard()
            {
                Id = 1,
                Make = new Builder()
                {
                    Id = 1,
                    Name = "Las Olas"
                },
                Model = "Plover",
                Length = 7.1f,
                Width = 22.4f,
                Shape = "MidLength",
                FinSetup = "2+1",
                Description = "The Plover is a mid length hull designed for small, fun, summer waves.  This board has a fully rolled bottom contour which transitions to a paneled vee out of the tail.  This board is designed to turn and trim in waves from knee to head high and excels in clean, point surf.",
                Rating = 4f,
                ImageFileName = "las-olas_plover.jpg",
                //return (Make.Name.Replace(' ', '-').ToLower() + '_' + Model.Replace(' ', '-') + ".jpg").ToLower();
    },
            new Surfboard()
            {
                Id = 2,
                Make = new Builder()
                {
                    Id = 2,
                    Name = "Ghetto"
                },
                Model = "Fuggly Model",
                Length = 9.7f,
                Width = 23.5f,
                Shape = "Longboard",
                FinSetup = "Single",
                Description = "Traditional noseriding log. Will treat you right on those near flat (to chest high) beach breaks.",
                Rating = 4.2f,
                ImageFileName = "ghetto_fuggly.jpg",
            },
            new Surfboard()
            {
                Id = 3,
                Make = new Builder()
                {
                    Id = 3,
                    Name = "Mayo",
                },
                Model = "Twin Keel",
                Length = 6.3f,
                Width = 22.5f,
                Shape = "Fish",
                FinSetup = "Twin",
                Description = "A loose and speedy ride.  Pairs well with soft faced waves and groundswell.",
                Rating = 4.1f,
                ImageFileName = "mayo_twin-keel.jpg",
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

        public List<Surfboard> GetSurfboards()
        {
            return _surfboards;
        }

        public void AddSurfboard(Surfboard newBoard)
        {
            // Get the next available entry ID.
            int nextAvailableEntryId = _surfboards.Max(s => s.Id) + 1;

            /// if builder already exists, import that builder id...
            /// if not... 
            /// ... use nextAvailableId to create builderId
            newBoard.Make.Id = _surfboards.Max(s => s.Make.Id) + 1;
            
            newBoard.Id = nextAvailableEntryId;

            _surfboards.Add(newBoard);
        }
    }
}