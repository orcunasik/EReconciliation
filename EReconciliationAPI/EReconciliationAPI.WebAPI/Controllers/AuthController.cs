﻿using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Entities.Concrete;
using EReconciliationAPI.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EReconciliationAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(UserAndCompanyRegisterDto userAndCompanyRegister)
        {
            var userExists = _authService.UserExists(userAndCompanyRegister.userForRegister.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var compantExists = _authService.CompanyExists(userAndCompanyRegister.company);
            if (!compantExists.Success)
            {
                return BadRequest(compantExists.Message);
            }

            var registerResult = _authService.Register(userAndCompanyRegister.userForRegister, userAndCompanyRegister.userForRegister.Password,userAndCompanyRegister.company);
            var result = _authService.CreateAccessToken(registerResult.Data, registerResult.Data.CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
           
            return BadRequest(registerResult.Message);
        }

        [HttpPost("registerSecondAccount")]
        public IActionResult RegisterSecondAccount(UserForRegisterDto userForRegister, int companyId)
        {
            var userExists = _authService.UserExists(userForRegister.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }
            var registerResult = _authService.RegisterSecondAccount(userForRegister, userForRegister.Password);
            var result = _authService.CreateAccessToken(registerResult.Data,companyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(registerResult.Message);
        }

        [HttpPost("login")]
        public IActionResult  Login(UserForLoginDto userForLogin)
        {
            var userToLogin = _authService.Login(userForLogin);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }
            var result = _authService.CreateAccessToken(userToLogin.Data, 0);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}