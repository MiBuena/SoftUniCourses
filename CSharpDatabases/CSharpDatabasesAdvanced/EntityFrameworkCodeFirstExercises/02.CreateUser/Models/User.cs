using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using _02.CreateUser.Attributes;

namespace _02.CreateUser.Models
{
    public class User
    {
        private string password;
        private string email;
        private string symbols = "!@#$%^&*()_+<>?";

        public User()
        {

        }


        public User(string password, string email, string username,  DateTime registeredOn, DateTime lastTimeLoggedIn, int age, bool isDeleted, DateTime deletedOn)
        {
            this.Password = password;
            this.Email = email;
            this.Username = username;
            this.RegisteredOn = registeredOn;
            this.LastTimeLoggedIn = lastTimeLoggedIn;
            this.Age = age;
            this.IsDeleted = isDeleted;
            this.DeletedOn = deletedOn;
        }







        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string Lastname { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return this.FirstName + " " + this.Lastname; }
        }


        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [RegularExpression("\\w+", ErrorMessage = "White space found")]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        [Password(3, 30, ShouldContainUppercase = false, ShouldContainDigit = true)]
        public string Password
        {
            get { return this.password; }
            set
            {
                //if (!value.Any(x => char.IsUpper(x)) || !value.Any(x => char.IsLower(x)) || !value.Any(x => char.IsDigit(x)) || !value.Any(x => this.symbols.Contains(x)))
                //{
                //    throw new ArgumentException();
                //}

                this.password = value;
            }
        }

        [Required]
        [Email]
        public string Email
        {
            get { return this.email; }
            set
            {

                this.email = value;
            }

        }

        public Town BirthTown { get; set; }

        public Town LivingTown { get; set; }



        public DateTime RegisteredOn { get; set; }

        public DateTime LastTimeLoggedIn { get; set; }


        [Range(1, 120)]
        public int Age { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeletedOn { get; set; }

        public virtual ICollection<User> Friends { get; set; } 

        public virtual ICollection<Album> Albums { get; set; } 

        private bool ValidateEmail(string value)
        {
            string[] parameters = value.Split('@');

            bool isUserValid = ValidateUser(parameters[0]);

            bool isHostValid = ValidateHost(parameters[1]);

            return isHostValid && isUserValid;
        }

        private bool ValidateHost(string host)
        {
            string pattern = @"(\w+\.\w+)(\.\w+)*";

            Regex regex = new Regex(pattern);
            bool containsValidHost = regex.IsMatch(host);

            return containsValidHost;
        }

        private bool ValidateUser(string user)
        {
            string pattern = @"\w*\d*(?<!^).*_*-*(?!$)\w*\d*";

            Regex regex = new Regex(pattern);
            bool containsValidUser = regex.IsMatch(user);


            return containsValidUser;
        }
    }
}
