﻿using System;
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
        public string Shape { get; set; }
        public string FinSetup { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }

        public string DisplayText
        {
            get
            {
                return Make.Name.ToString() + " : " + Model + " : " + Length;
            }
        }

        public string ImageFileName
        {
            get
            {
                return (Make.Name.Replace(' ', '-').ToLower() + '_' + Model.Replace(' ', '-') + ".jpg").ToLower();
            }
        }
    }
}