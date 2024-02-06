﻿using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicanteService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}