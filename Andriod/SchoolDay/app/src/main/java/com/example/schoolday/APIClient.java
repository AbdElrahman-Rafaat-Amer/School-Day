package com.example.schoolday;

import com.example.schoolday.student.NoteInterface;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;


public class APIClient {

    public static Retrofit getRetrofit() {
        Gson gson = new GsonBuilder()
                .setDateFormat("yyyy-MM-dd'T'HH:mm:ss")
                .create();

        Retrofit retrofit = new Retrofit.Builder().baseUrl("http://nabilhelmy313-001-site2.htempurl.com/")
                .addConverterFactory(GsonConverterFactory.create()).build();
        return retrofit;
    }

    public static LoginInterface getLoginService() {
        LoginInterface loginInterface = getRetrofit().create(LoginInterface.class);
        return loginInterface;
    }


    public static NoteInterface getNoteService() {
        NoteInterface noteInterface = getRetrofit().create(NoteInterface.class);
        return noteInterface;
    }
}

