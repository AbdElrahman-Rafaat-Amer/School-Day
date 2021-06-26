package com.example.schoolday.teacher;

import retrofit2.Call;
import retrofit2.http.GET;

public interface TeacherStudentInteface {

    @GET("StudentRate/selectYear")
    Call<String> getSelectYear();

    @GET("StudentRate/selectclass")
    Call<String> getSelectClass();
}
