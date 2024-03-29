﻿using ProjectCamp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCamp.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category );
        void CategoryDelete(Category category );
        void CategoryUpdate(Category category );
        Category GetById(int id);
        List<Category> GetAll();
    }
}
