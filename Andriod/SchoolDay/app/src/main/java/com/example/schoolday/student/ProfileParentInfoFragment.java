package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import androidx.fragment.app.Fragment;

import com.example.schoolday.R;

public class ProfileParentInfoFragment extends Fragment {

    EditText fatherName , fatherJob, fatherPhone, motherName, motherJob, motherPhone, email, relationWithGuardian, guardianAddress, guardianName;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_profile_parent_info, container, false);

        fatherName = view.findViewById(R.id.father_name);
        fatherJob = view.findViewById(R.id.father_job);
        fatherPhone = view.findViewById(R.id.father_phone_number);
        motherName = view.findViewById(R.id.mother_name);
        motherPhone = view.findViewById(R.id.mother_phone_number);
        motherJob = view.findViewById(R.id.mother_job);
        email = view.findViewById(R.id.parent_email);
        relationWithGuardian = view.findViewById(R.id.relation_with_guardian);
        guardianAddress = view.findViewById(R.id.guardin_address);
        guardianName = view.findViewById(R.id.guardin_name);

        return view;
    }
}