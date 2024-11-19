﻿namespace MyAPI.DTOs.DriverDTOs
{
    public class UpdateDriverDTO
    {

        public string UserName { get; set; }
        public string Name { get; set; }
        public string NumberPhone { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        public string? StatusWork { get; set; }
        public int TypeOfDriver { get; set; }
        public bool? Status { get; set; }
    }
}