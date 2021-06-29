package com.example.schoolday.parent.feespackage;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;

public interface FeesInterface {
    @GET("Fees")
    Call<ArrayList<Fees>> getFees();

    @POST("Fess")
    Call<Void> postFees(@Body Fees fees);
}
