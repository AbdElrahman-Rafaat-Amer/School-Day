package com.example.schoolday.signup;

import com.example.schoolday.login.LoginRequest;
import com.example.schoolday.login.LoginResponse;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;

public interface SignupInterface {
    @POST("/Accounts/register")
    Call<Void> signupUser(@Body SignupRequest signupRequest);

}
