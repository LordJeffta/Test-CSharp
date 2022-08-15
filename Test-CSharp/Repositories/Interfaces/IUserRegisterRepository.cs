using DTOs.DTOs;

namespace Test_CSharp.Repositories.Interfaces;

public interface IUserRegisterRepository
{
    Task<UserRegisterDto> AddUser(UserRegisterDto userRegisterDto, UserRegisterAddDto userRegisterAddDto);
}