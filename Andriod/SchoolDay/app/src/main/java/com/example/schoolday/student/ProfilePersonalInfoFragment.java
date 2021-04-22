package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import androidx.fragment.app.Fragment;

import com.example.schoolday.R;


public class ProfilePersonalInfoFragment extends Fragment {

    EditText genderText, dateOfBirth, admissionDate, phoneNumber, emailAddress, presentAddress, permanentAddress ;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_profile_personal_info, container, false);

        genderText = view.findViewById(R.id.type_gender);
        dateOfBirth = view.findViewById(R.id.date_of_birth);
        admissionDate = view.findViewById(R.id.admission_date);
        phoneNumber = view.findViewById(R.id.phone_number);
        emailAddress = view.findViewById(R.id.email_address);
        permanentAddress = view.findViewById(R.id.present_address);
        permanentAddress = view.findViewById(R.id.permanent_address);

        return view;
    }
}