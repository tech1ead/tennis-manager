﻿using Tennis.Database.Models;
using Tennis.Repository.GenericRepository;
namespace Tennis.Repository.UserRepository;
public interface IUserRepository : IGenericRepository<User>
{
}
