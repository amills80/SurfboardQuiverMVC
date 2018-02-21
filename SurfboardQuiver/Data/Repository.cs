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
                Shape = BoardShape.Midlength,
                //Shape = "MidLength",
                FinSetup = FinSetup.Two_Plus_One,
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
                Shape = BoardShape.Longboard,
                FinSetup = FinSetup.Single,
                Description = "Traditional noseriding log. Will treat you right on those near flat (to chest high) beach breaks.",
                Rating = 4.2f,
                ImageFileName = "ghetto_fuggly-model.jpg",
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
                Shape = BoardShape.Fish,
                FinSetup = FinSetup.Keel,
                Description = "A loose and speedy ride.  Pairs well with soft faced waves and groundswell.",
                Rating = 4.1f,
                ImageFileName = "mayo_twin-keel.jpg",
            },
            new Surfboard()
            {
                Id = 4,
                Make = new Builder()
                {
                    Id = 4,
                    Name = "Clay Bennett"
                },
                Model = "Banshee Model",
                Length = 9.5f,
                Width = 23,
                Shape = BoardShape.Longboard,
                FinSetup = FinSetup.Two_Plus_One,
                Description = "Great all around longboard for beach break conditions. Has a modest nose and tail rocker to fit into some steeper waves while still having great turning and noseriding ability. Has a center channel in the center portion of the board to provide a little extra release and allow the board to get more vertical.",
                //Description = "The Knows Boogie is a modern take on a traditional log.  It has a slight step deck with a concave under the nose and a subtly kicked rocker in the tail.  The 50/50 rails help this board turn and trim in any type of surf. The knows boogie is a great all around nose rider for a wide verity of surf and is designed for beginner to advanced surfers in knee to shoulder high surf.",
                Rating = 4.4f,
                ImageFileName = "clay-bennett_banshee-model.jpg",
            }
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