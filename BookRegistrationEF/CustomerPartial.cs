﻿
namespace BookRegistrationEF
{
    public partial class Customer
    {
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
