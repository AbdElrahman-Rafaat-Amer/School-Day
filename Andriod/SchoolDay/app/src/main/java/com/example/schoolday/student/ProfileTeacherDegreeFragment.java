package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ProgressBar;
import android.widget.TextView;

import androidx.cardview.widget.CardView;
import androidx.fragment.app.Fragment;

import com.example.schoolday.R;

import de.hdodenhof.circleimageview.CircleImageView;


public class ProfileTeacherDegreeFragment extends Fragment {

    TextView assignmentName, rate;
    CardView subjectContainer;
    CircleImageView circleImageView;
    ProgressBar progressBar;
    int rateValue;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_profile_teacher_degree, container, false);

        assignmentName = view.findViewById(R.id.assignment_name);
        rate = view.findViewById(R.id.assignment_proteacher_rate);
        circleImageView = view.findViewById(R.id.assignment_logo);
        subjectContainer = view.findViewById(R.id.assignment_container);
        progressBar = view.findViewById(R.id.progrssbar_profteacher);

       // rateValue = progressBar.getProgress();
        //rate.setText(rateValue);


        return view;
    }
}