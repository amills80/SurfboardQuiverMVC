using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfboardQuiver.Models
{
    public enum BoardShape
    {
        Longboard, 
        Midlength, 
        Fish,
        Hybrid,
        Shortboard,
        Other
    }

    public enum FinSetup
    {
        Single,
        Two_Plus_One,
        Twin,
        Keel,
        Quad,
        Thruster,
        Bonzer,
        Other
    }

    public class Surfboard
    {
        public int Id { get; set; }
        public Builder Make { get; set; }
        public string Model { get; set; }
        public BoardShape Shape { get; set; }
        public FinSetup FinSetup { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public string ImageFileName { get; set; }
        //{
        //    get
        //    {
        //        return (Make.Name.Replace(' ', '-').ToLower() + '_' + Model.Replace(' ', '-') + ".jpg").ToLower();
        //    }
        //}

        public string DisplayText
        {
            get
            {   // TODO: refactor this if section
                if(Make.Name == null)
                {
                    Make.Name = "";
                }
                if(Model == null)
                {
                    Model = "";
                }
                return Make.Name.ToString() + " : " + Model + " : " + Length;
            }
        }
    }
}