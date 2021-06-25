package com.example.schoolday.student.notepackage;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;

public interface NoteInterface {

    @GET("Note/ListOfNotes")
    Call<ArrayList<Notes>> getNote();

    @POST("Note/CreateNote")
    Call<NoteResponse> createNote(@Body  NoteRequest noteRequest);

    @PUT("Note/Note")
    Call<Void> saveNote(@Body Notes notes);

    @DELETE("Note/id")
    Call<Void>deleteNote();

}
