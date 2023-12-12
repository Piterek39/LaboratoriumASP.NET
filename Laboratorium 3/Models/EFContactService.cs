using Data.Entities;
using Data;
using Data.Models;
using Microsoft.Extensions.Logging.Abstractions;

namespace Laboratorium_3.Models
{
    public class EFContactService : IContactService
    {
        private AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact contact)
        {
            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            e.Entity.Created=DateTime.Now;
            _context.SaveChanges();
            return e.Entity.Id;         
        }

        public void Delete(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            if (find != null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList(); ;
        }

        public Contact? FindById(int id)
        {
            ContactEntity? find=_context.Contacts.Find(id);
            return find == null ? null : ContactMapper.FromEntity(find);
        }

        public void Update(Contact contact)
        {
            ContactEntity entity = ContactMapper.ToEntity(contact);
            _context.Update(entity);
            _context.SaveChanges();    
        }
        public List<OrganizationEntity> FindAllOrganizations()
        {
            return _context.Organizations.ToList();           
        }
        public PagingList<Contact> FindPage(int page, int size)
       {
           /* int totalCount = _context.Contacts.Count();
            List<Contact> contacts = _context.Contacts
                .Skip((page - 1) * size)
                .Take(size)
                .ToList();*/
            var data = _context.Contacts
                 .Skip((page - 1) * size)
                 .Take(size)
               .ToList();         
            return PagingList<Contact>.Create((ICollection<Contact>)data, _context.Contacts.Count(), page, size);
       } 
        /*public PagingList<Contact> FindPage(int page, int size)
        {
            return PagingList<Contact>.Create(
                    (p, s) => 
                    _context.Contacts
                            .OrderBy(b => b.)
                            .Skip((p - 1) * size)
                            .Take(s)
                            .ToList(),
                    _context.Contacts.Count(),
                    page,
                    size);
        }*/
    }
}
