﻿using HR.LeaveManagement.MVC.Contracts;
using System;
using System.Net.Http.Headers;

namespace HR.LeaveManagement.MVC.Services.Base
{
    public class BaseHttpService
    {
        protected readonly IClient _client;
        protected readonly ILocalStorageService _localStorage;

        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation errors have occurred.", ValidationErrors = ex.Response, Success = false };
            }
            else if (ex.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "The requested item could not be found.", Success = false };
            }
            else
            {
                return new Response<Guid>() { Message = "Something went wrong, please try again.", Success = false };
            }
        }

        protected void AddBearerToken()
        {
            if (_localStorage.Exists("token"))
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _localStorage.GetStorageValue<string>("token"));
        }
    }
}