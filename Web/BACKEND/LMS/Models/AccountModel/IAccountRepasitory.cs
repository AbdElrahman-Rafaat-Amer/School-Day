﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AccountModel
{
    interface IAccountRepasitory
    {
<<<<<<< HEAD
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        void RevokeToken(string token, string ipAddress);
        void Register(RegisterRequest model, string origin);
        void VerifyEmail(string token);
        void ForgotPassword(ForgotPasswordRequest model, string origin);
        void ValidateResetToken(ValidateResetTokenRequest model);
        void ResetPassword(ResetPasswordRequest model);
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        IEnumerable<AccountResponse> GetAll();
        AccountResponse GetById(int id);
        AccountResponse Create(CreateRequest model);
        AccountResponse Update(int id, UpdateRequest model);
        void Delete(int id);
=======
>>>>>>> parent of 98e6a8c (Account works by Repository Pattern)
    }
}
