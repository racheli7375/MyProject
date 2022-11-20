using AutoMapper;
using MyPeoject.Common;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
   public class RoleService: IRoleService
    {

        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;


        public RoleService(IRoleRepository context,IMapper mapper)
            {
            _roleRepository = context;
            _mapper=mapper;
            }

        public RoleDTO Add(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<RoleDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public RoleDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public RoleDTO Update(Role role)
        {
            throw new NotImplementedException();
        }

        //public Role Add(int id, string name, string description)
        //{
        //    Role r = new Role() { Id = id, Name = name, Description = description };
        //    _context.Roles.Add(r);
        //    return r;
        //}

        //public void Delete(int id)
        //{
        //    _context.Roles.Remove(GetById(id));
        //}

        //public List<Role> GetAll()
        //{
        //    return _context.Roles;
        //}

        //public Role GetById(int id)
        //{
        //    return _context.Roles.Find(r => r.Id == id);
        //}

        //public Role Update(Role role)
        //{
        //    Role r1 = GetById(role.Id);
        //    r1.Name = role.Name;
        //    r1.Description = role.Description;
        //    return r1;

        //}
    }
    }

