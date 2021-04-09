﻿using API_01.Models;
using System.Collections.Generic;

namespace API_01.Interfaces.Repository
{
    public interface IContaRepository
    {
        IEnumerable<ContaModel> GetAll();

        ContaModel GetOne(int id);

        ContaModel Update(ContaModel conta);

        ContaModel Insert(ContaModel conta);

        bool Delete(ContaModel conta);

        IEnumerable<ContaModel> GetByName(string name);

        ContaModel GetByEmail(string email);

        bool ContactNameExist(int codigo, string name);

        bool ContactEmailExist(int codigo, string email);
    }
}
