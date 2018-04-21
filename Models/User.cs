using System;

namespace efCode.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }

        public User(string name, Gender gender, DateTime birthday)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
        }

        public User() {}

        public override string ToString() => $"name:Name;gender:Gender;birthday:Birthday";
    }

    public enum Gender
    {
        MALE, FEMALE
    }
}