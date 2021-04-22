package com.example.schoolday.teacher;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import com.example.schoolday.R;


public class FragmentTeacherSubjectTwo extends Fragment {


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_teacher_subject_two, container, false);

        String[] subjectName = { };
        Spinner acYearSpin = view.findViewById(R.id.acadimic_year_spinner);
        ArrayAdapter<String> ACYadapter = new ArrayAdapter<String>(this.getActivity(), android.R.layout.simple_spinner_item, subjectName);
        ACYadapter.setDropDownViewResource(android.R.layout.simple_dropdown_item_1line);
        acYearSpin.setAdapter(ACYadapter);




        return view;
    }
}