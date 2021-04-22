package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import androidx.fragment.app.Fragment;

import com.example.schoolday.R;

public class ProfileOtherInfoFragment extends Fragment {

    EditText bloodGroup, height, weight, perviousSchoolDetails, nationalIdentityNumber, localIdentityNumber, bankAccount, bankName;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_profile_other_info, container, false);

        bloodGroup = view.findViewById(R.id.blood_group);
        height = view.findViewById(R.id.height);
        weight = view.findViewById(R.id.weight);
        perviousSchoolDetails = view.findViewById(R.id.pervious_school_details);
        nationalIdentityNumber = view.findViewById(R.id.national_identity_number);
        localIdentityNumber = view.findViewById(R.id.local_identity_number);
        bankAccount = view.findViewById(R.id.bank_account);
        bankName = view.findViewById(R.id.bank_name);

        return view;
    }
}