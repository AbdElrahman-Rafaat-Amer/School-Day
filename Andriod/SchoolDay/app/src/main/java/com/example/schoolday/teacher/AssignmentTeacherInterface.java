package com.example.schoolday.teacher;

import retrofit2.Call;
import retrofit2.http.GET;

public interface AssignmentTeacherInterface {

@GET("Chapters/ListYear")
    Call<String> getListYear();

}
