package com.example.schoolday.student.feespackage;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.GET;

public interface FeesInterface {
    @GET("Fees")
    Call<ArrayList<Fees>> getFees();
}
