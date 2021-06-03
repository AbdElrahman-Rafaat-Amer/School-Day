package com.example.schoolday;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;

public interface LoginInterface {
    @POST("Accounts/Login")
    Call<LoginResponse> userlogin(@Body LoginRequest loginRequest);


}
