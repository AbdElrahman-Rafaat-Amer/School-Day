package com.example.schoolday.teacher.assignment;

import com.example.schoolday.student.notepackage.NoteRequest;
import com.example.schoolday.student.notepackage.NoteResponse;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;

public interface AssignmentTeacherInterfaceSecond {
    @GET("api/ShowAssignment/UploadPDFAssigment")
    Call<AssignmentTeacherFragmentResponse> upload(@Body AssignmentTeacherFragmentRequest assignmentTeacherFragmentRequest);
}
