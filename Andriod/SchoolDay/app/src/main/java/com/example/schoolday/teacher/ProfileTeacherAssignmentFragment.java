package com.example.schoolday.teacher;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.fragment.app.Fragment;

import com.example.schoolday.R;

import de.hdodenhof.circleimageview.CircleImageView;

public class ProfileTeacherAssignmentFragment extends Fragment {

    TextView subjectName;
    CircleImageView circleImageView;
    ImageView imageView;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_profile_teacher_assignment, container, false);

        subjectName = view.findViewById(R.id.subject_name);
        circleImageView = view.findViewById(R.id.subject_logo);
        imageView = view.findViewById(R.id.gotoassin);
        return view;
    }
}