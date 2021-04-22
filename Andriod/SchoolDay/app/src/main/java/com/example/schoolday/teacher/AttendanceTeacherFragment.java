package com.example.schoolday.teacher;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import com.example.schoolday.R;


public class AttendanceTeacherFragment extends Fragment {


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view =  inflater.inflate(R.layout.fragment_attendance_teacher, container, false);
        String[] acadimicYear = { "First Year", "Second Year", "Third Year", "Fourth Year", "Fifth Year", "Sixth Year" };
        Spinner acYearSpin = view.findViewById(R.id.acadimic_year_spinner);
        ArrayAdapter<String> ACYadapter = new ArrayAdapter<String>(this.getActivity(), android.R.layout.simple_spinner_item, acadimicYear);
        ACYadapter.setDropDownViewResource(android.R.layout.simple_dropdown_item_1line);
        acYearSpin.setAdapter(ACYadapter);

        String[] selectClass = { "First ", "Second ", "Third ", "Fourth ", "Fifth ", "Sixth " };
        Spinner sClassSpin = view.findViewById(R.id.acadimic_year_spinner);
        ArrayAdapter<String> SCadapter = new ArrayAdapter<String>(this.getActivity(), android.R.layout.simple_spinner_item, selectClass);
        SCadapter.setDropDownViewResource(android.R.layout.simple_dropdown_item_1line);
        sClassSpin.setAdapter(SCadapter);

        return view;
    }
}