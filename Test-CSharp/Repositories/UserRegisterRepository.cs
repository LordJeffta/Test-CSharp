using DTOs.DTOs;
using Microsoft.EntityFrameworkCore;
using Test_CSharp.Entities;
using Test_CSharp.Repositories.Interfaces;
using Test_CSharp.data;

namespace Test_CSharp.Repositories;

public class UserRegisterRepository : IUserRegisterRepository
{
    private readonly DataContext _dataContext;

    public UserRegisterRepository(DataContext dataContext)
    {
        this._dataContext = dataContext;
    }

    public async Task<UserRegisterDto> AddUser(UserRegisterDto userRegisterDto, UserRegisterAddDto userRegisterAddDto)
    {
        var addUser = await (from user in this._dataContext.Users select new UserRegisterAddDto());
    }
}