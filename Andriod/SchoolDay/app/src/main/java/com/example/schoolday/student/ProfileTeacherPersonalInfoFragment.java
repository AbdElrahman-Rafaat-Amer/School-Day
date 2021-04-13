package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import androidx.fragment.app.Fragment;

import com.example.schoolday.R;


public class ProfileTeacherPersonalInfoFragment extends Fragment {

    EditText teacherNameText, jobText, phoneNumberText, genderText;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_profile_teacher_personal_info, container, false);

        teacherNameText = view.findViewById(R.id.teacher_name);
        jobText = view.findViewById(R.id.teacher_job);
        phoneNumberText = view.findViewById(R.id.teacher_phone_number);
        genderText = view.findViewById(R.id.teacher_gender_type);

        return view;
    }
}