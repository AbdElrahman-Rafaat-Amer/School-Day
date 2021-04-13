package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.TextView;

import androidx.cardview.widget.CardView;
import androidx.fragment.app.Fragment;

import com.example.schoolday.R;

import de.hdodenhof.circleimageview.CircleImageView;

public class ProfileTeacherTimeTableFragment extends Fragment {

    TextView subjectName, subjectDay, subjectTime;
    CircleImageView circleImageView;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_profile_teacher_timetable, container, false);

        subjectName = view.findViewById(R.id.subject_name);
        subjectDay = view.findViewById(R.id.subject_day);
        subjectTime = view.findViewById(R.id.subject_time);
        circleImageView = view.findViewById(R.id.subject_logo);

        return view;
    }
}