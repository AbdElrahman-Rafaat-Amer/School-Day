package com.example.schoolday;

import com.example.schoolday.login.LoginInterface;
import com.example.schoolday.signup.SignupInterface;
import com.example.schoolday.student.feedpackage.FeedInterface;
import com.example.schoolday.student.notepackage.NoteInterface;
import com.example.schoolday.teacher.assignment.AssignmentTeacherInterfaceSecond;
import com.example.schoolday.teacher.assignment.AssignmentTeacherSpinnerInterface;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import okhttp3.OkHttpClient;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;


public class APIClient {

    public static Retrofit getRetrofit() {


        Retrofit retrofit = new Retrofit.Builder().baseUrl("http://nabilhelmy313-001-site2.htempurl.com/")
                .addConverterFactory(GsonConverterFactory.create()).build();
        return retrofit;
    }

    public static LoginInterface getLoginService() {
        LoginInterface loginInterface = getRetrofit().create(LoginInterface.class);
        return loginInterface;
    }

    public static SignupInterface getSignupService() {

        SignupInterface signupInterface = getRetrofit().create(SignupInterface.class);
        return signupInterface;
    }

    public static NoteInterface getNoteService() {
        NoteInterface noteInterface = getRetrofit().create(NoteInterface.class);
        return noteInterface;
    }

    public static FeedInterface getFeedService() {
        FeedInterface feedInterface = getRetrofit().create(FeedInterface.class);
        return feedInterface;
    }

    public static AssignmentTeacherSpinnerInterface getSpinnerService() {
        AssignmentTeacherSpinnerInterface spinnerInterface = getRetrofit().create(AssignmentTeacherSpinnerInterface.class);
        return spinnerInterface;
    }

    public static AssignmentTeacherInterfaceSecond getAssignmentService() {
        AssignmentTeacherInterfaceSecond assignmentTeacherInterfaceSecond = getRetrofit().create(AssignmentTeacherInterfaceSecond.class);
        return assignmentTeacherInterfaceSecond;

    }
}
