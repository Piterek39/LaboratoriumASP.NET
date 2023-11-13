﻿using Data.Entities;

namespace Laboratorium_3.Models
{
    public class ContactMapper
    {
        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                Birth = entity.Birth,
                Priority=(Priority)Enum.Parse(typeof(Priority),(entity.Priority)),              
                Created=entity.Created,
            };
        }

        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Birth = model.Birth,
                Priority=model.Priority.ToString(), 
                Created = model.Created,
            };
        }
    }
}
