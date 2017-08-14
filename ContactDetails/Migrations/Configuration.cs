namespace ContactDetails.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactDetails.Models.ContactDetailsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ContactDetails.Models.ApplicationDbContext";
        }

        protected override void Seed(ContactDetails.Models.ContactDetailsContext context)
        {
            /*
             * 1819c190-b9cd-4364-8027-f6c02ca8b3ba
            55fbb2a5-bf80-44dc-92b7-2aafce1245f2
            */

            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Models.Contact { Id = 1, Birthday = new DateTime(1920, 01, 20), City = "Chicago"
                                    , Email = "doc.mccoy@starfleet.com", FirstName = "DeForest", LastName = "Kelley"
                                    , PhonePrimary = "123-456-7890", PhoneSecondary = "234-567-8901", State = "IL"
                                    , StreetAddress1 = "Sickbay", StreetAddress2 = "Starship Enterprise NCC-1701"
                                    , UserId = new Guid("1819c190-b9cd-4364-8027-f6c02ca8b3ba")
                                    , Zip = "98765" } 
                , new Models.Contact { Id = 2, Birthday = new DateTime(1920, 03, 03), City = "New York"
                                    , Email = "i.beam.you.up@starfleet.com", FirstName = "James", LastName = "Doohan"
                                    , PhonePrimary = "345-678-9012", PhoneSecondary = "456-789-0123", State = "NY"
                                    , StreetAddress1 = "Engineering", StreetAddress2 = "Starship Enterprise NCC-1701"
                                    , UserId = new Guid("1819c190-b9cd-4364-8027-f6c02ca8b3ba")
                                    , Zip = "87654" }
                , new Models.Contact { Id = 3, Birthday = new DateTime(1931, 03, 26), City = "Los Angeles"
                                    , Email = "its.only.logic@starfleet.com", FirstName = "Leonard", LastName = "Nimoy"
                                    , PhonePrimary = "987-654-3210", PhoneSecondary = "876-543-2109", State = "CA"
                                    , StreetAddress1 = "Science Station 1", StreetAddress2 = "Starship Enterprise NCC-1701"
                                    , UserId = new Guid("55fbb2a5-bf80-44dc-92b7-2aafce1245f2")
                                    , Zip = "76543-2109" }
                , new Models.Contact { Id = 4, Birthday = new DateTime(1931, 03, 22), City = "Riverside"
                                    , Email = "the.captain@starfleet.com", FirstName = "William", LastName = "Shatner"
                                    , PhonePrimary = "765-432-1098", PhoneSecondary = "654-321-0987", State = "IA"
                                    , StreetAddress1 = "The Bridge", StreetAddress2 = "Starship Enterprise NCC-1701"
                                    , UserId = new Guid("55fbb2a5-bf80-44dc-92b7-2aafce1245f2")
                                    , Zip = "65432-0123" }
            );
        }
    }
}
