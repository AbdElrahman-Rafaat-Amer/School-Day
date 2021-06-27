package com.example.schoolday.teacher.assignment;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.GET;

public interface AssignmentTeacherSpinnerInterface {

    @GET("Chapters/ListYear")
    Call<ArrayList<AssignmentYearResponse>> getListYear();
    @GET("Chapters/ListSubject")
    Call<ArrayList<AssignmentSubjectResponse>> getListSubject();

}
