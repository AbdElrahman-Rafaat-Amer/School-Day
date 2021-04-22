package com.example.schoolday.teacher;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;

import androidx.cardview.widget.CardView;
import androidx.fragment.app.Fragment;

import com.example.schoolday.R;


public class ExamTeacherFragment extends Fragment {

    CardView uploadExam;
    ImageView enterTheExam;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_exam_teacher, container, false);
        uploadExam = view.findViewById(R.id.teacher_upload_exam);
        enterTheExam = view.findViewById(R.id.goTOexamTeacher);

        return view;
    }
}