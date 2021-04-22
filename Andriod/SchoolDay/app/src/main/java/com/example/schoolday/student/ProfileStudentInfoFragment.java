package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import androidx.fragment.app.Fragment;

import com.example.schoolday.R;


public class ProfileStudentInfoFragment extends Fragment {

    EditText studentNameText, rollNumberText, classText, sectionText, genderText;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_profile_student_info, container, false);

        studentNameText = view.findViewById(R.id.student_name);
        rollNumberText = view.findViewById(R.id.roll_number);
        classText = view.findViewById(R.id.class_number);
        sectionText = view.findViewById(R.id.section_number);
        genderText = view.findViewById(R.id.gender_type);

        return view;
    }
}