package com.example.schoolday.student.downloadspackage;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.http.GET;

public interface DownloadInterface {
    @GET("/Downloads/SubjectList")
    Call<ArrayList<Downloads>> getDownload();
}
