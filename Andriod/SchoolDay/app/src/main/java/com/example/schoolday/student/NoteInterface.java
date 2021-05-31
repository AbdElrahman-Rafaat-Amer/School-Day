package com.example.schoolday.student;

import com.example.schoolday.UserRequest;
import com.example.schoolday.UserResponse;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;

public interface NoteInterface {

    @GET("Note/ListNote")
    Call<ArrayList<Notes>> getNote();
    @PUT("Note/UpdateNote")
    Call<NoteResponse> saveNote(@Body NoteRequest noteRequest);

}
