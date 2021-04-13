package com.example.schoolday.student;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;

import com.example.schoolday.R;
import com.example.schoolday.teacher.TeacherProfileFragment;

public class TeacherFragment extends Fragment {

    ImageView goToProfTeacher;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

         View view = inflater.inflate(R.layout.fragment_teacher, container, false);

         goToProfTeacher = view.findViewById(R.id.go_to_profteacher);
         goToProfTeacher.setOnClickListener(new View.OnClickListener() {
             @Override
             public void onClick(View v) {
                 getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new TeacherProfileFragment()).commit();
             }
         });
         return view;
    }
}