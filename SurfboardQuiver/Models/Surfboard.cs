using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfboardQuiver.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public Builder Make { get; set; }
        public string Model { get; set; }
        // TODO: Change shape from string to enum for preset values. 
        // Then change createBoard page to use a drop down instead of a text box.
        public string Shape { get; set; }
        public string FinSetup { get; set; }
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