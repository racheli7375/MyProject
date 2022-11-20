﻿using MyPeoject.Common;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
   
    public interface IPermissionService
    {
        List<PermissionDTO> GetAll();

        PermissionDTO GetById(int id);

        PermissionDTO Add(int id, string name, string description);

        PermissionDTO Update(Permission Permission);

        void Delete(int id);

    }
}
