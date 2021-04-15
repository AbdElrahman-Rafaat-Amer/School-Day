package com.example.schoolday.student;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.GET;

public interface NoteInterface {

    @GET("marvel")
    Call<ArrayList<Notes>>getNote();


}
