package com.example.schoolday.student.feedpackage;

import com.example.schoolday.student.notepackage.NoteRequest;
import com.example.schoolday.student.notepackage.NoteResponse;

import okhttp3.RequestBody;
import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;
import retrofit2.http.Part;

public interface FeedInterface {
    @POST("Feeds/AddPost")
    Call<AddFeedResponse> addPost(@Part("image\"; filename=\"myfile.jpg\" ") RequestBody file, @Part("desc") RequestBody desc);
    @POST("Feeds/AddPost")
   Call<AddFeedResponse> addPost(@Body AddPostRequest addPostRequest);
}
