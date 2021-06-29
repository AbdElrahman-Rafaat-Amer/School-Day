package com.example.schoolday.teacher.assignment;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.GET;

public interface AssignmentTeacherSpinnerInterface {

    @GET("api/ShowAssignment/ListYear")
    Call<ArrayList<AssignmentYearResponse>> getListYear();
    @GET("api/ShowAssignment/Listsubject")
    Call<ArrayList<AssignmentSubjectResponse>> getListSubject();

}
