using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name ="2 + 1")]
        Two_Plus_One,
        Twin,
        Quad,
        Thruster,
        Bonzer,
        Other
    }

    public class Surfboard
    {
        public int Id { get; set; }
        [Required]
        public Builder Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required, Display(Name = "Board Shape")]
        public BoardShape Shape { get; set; }
        [Display(Name = "Fin Setup")]
        public FinSetup FinSetup { get; set; }
        [Range(2, 13, ErrorMessage = "Please enter a valid board length, between 2 to 13 feet."), Display(Name = "Length (ft)")]
        public float Length { get; set; }
        [Range(12, 60, ErrorMessage = "Please enter a valid board width, between 12 to 60 inches."), Display(Name = "Width (in)")]
        public float Width { get; set; }
        [MaxLength(500, ErrorMessage = "Description: This field cannot exceed 500 characters.")]
        public string Description { get; set; }
        [Range(1, 5, ErrorMessage = "Rating: Please enter a number between one and five.")]
        public int Rating { get; set; }
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
                if (Make.Name == null)
                {
                    Make.Name = "";
                }
                if (Model == null)
                {
                    Model = "";
                }
                return Make.Name.ToString() + " : " + Model + " : " + Length;
            }
        }
    }
}