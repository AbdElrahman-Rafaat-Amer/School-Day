package com.example.schoolday.teacher.assignment;

import com.example.schoolday.teacher.assignment.AssignmentTeacher;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.GET;

public interface AssignmentTeacherInterface {
    @GET("api/ShowAssignment/ShowAssignment")
    Call<ArrayList<AssignmentTeacher>> getAssignmentTeacher();
}
