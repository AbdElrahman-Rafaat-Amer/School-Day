package com.example.schoolday.teacher.assignment;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;
import com.example.schoolday.login.LoginActivity;
import com.example.schoolday.teacher.assignment.AssignmentTeacherSpinnerInterface;
import com.example.schoolday.teacher.AssignmentTeacherSubject;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;


public class AssignmentTeacherFragment2 extends Fragment {
    Spinner subjectName, className;
    ArrayList<String> dropYears = new ArrayList<String>();
    ArrayList<AssignmentYearResponse> getYearArr = new ArrayList<AssignmentYearResponse>();
    ArrayList<String> dropSubjects = new ArrayList<String>();
    ArrayList<AssignmentSubjectResponse> getSubjectArr = new ArrayList<AssignmentSubjectResponse>();
    EditText assignmentName,assignmentStart,assignmentEnd;
    Button upload;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_assignment_teacher2, container, false);
        subjectName = view.findViewById(R.id.subjet_name_spinner);
        className = view.findViewById(R.id.select_class_spinner);
        assignmentName = view.findViewById(R.id.assignment_name);
        assignmentStart = view.findViewById(R.id.start_date);
        assignmentEnd = view.findViewById(R.id.end_date);
        upload = view.findViewById(R.id.uploadButton);

        AssignmentTeacherSpinnerInterface spinnerInterface = APIClient.getSpinnerService();
        spinnerInterface.getListYear().enqueue(new Callback<ArrayList<AssignmentYearResponse>>() {
            @Override
            public void onResponse(Call<ArrayList<AssignmentYearResponse>> call, Response<ArrayList<AssignmentYearResponse>> response) {
                getYearArr = response.body();

                for (AssignmentYearResponse yearResponse: getYearArr){
                    String tutorialsName = yearResponse.getYearName();
                    dropYears.add(tutorialsName);
                }

                ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(getContext(), android.R.layout.simple_spinner_dropdown_item, dropYears);
                arrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                className.setAdapter(arrayAdapter);
            }

            @Override
            public void onFailure(Call<ArrayList<AssignmentYearResponse>> call, Throwable t) {

            }
        });


        className.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {

                AssignmentYearResponse yearResponse = getYearArr.get(position);
                String tutorialsName = yearResponse.getYearName();
                Toast.makeText(parent.getContext(), "Selected: " + tutorialsName, Toast.LENGTH_LONG).show();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });


        spinnerInterface.getListSubject().enqueue(new Callback<ArrayList<AssignmentSubjectResponse>>() {
            @Override
            public void onResponse(Call<ArrayList<AssignmentSubjectResponse>> call, Response<ArrayList<AssignmentSubjectResponse>> response) {
                getSubjectArr = response.body();

                for (AssignmentSubjectResponse subjectResponse: getSubjectArr){
                    String tutorialsName = subjectResponse.getSubjectName();
                    dropSubjects.add(tutorialsName);
                }

                ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(getContext(), android.R.layout.simple_spinner_dropdown_item, dropSubjects);
                arrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                subjectName.setAdapter(arrayAdapter);
            }

            @Override
            public void onFailure(Call<ArrayList<AssignmentSubjectResponse>> call, Throwable t) {

            }
        });


        subjectName.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {

                AssignmentSubjectResponse subjectResponse = getSubjectArr.get(position);
                String tutorialsName = subjectResponse.getSubjectName();
                Toast.makeText(parent.getContext(), "Selected: " + tutorialsName, Toast.LENGTH_LONG).show();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });

upload.setOnClickListener(new View.OnClickListener() {
    @Override
    public void onClick(View v) {
        upload();
    }
});



        return view;
    }

    public void upload(){
        AssignmentTeacherFragmentRequest assignmentTeacherFragmentRequest = new AssignmentTeacherFragmentRequest();
        assignmentTeacherFragmentRequest.setAssignmentName(assignmentName.getText().toString());
        assignmentTeacherFragmentRequest.setStartDate(assignmentStart.getText().toString());
        assignmentTeacherFragmentRequest.setEndDate(assignmentEnd.getText().toString());


        Call<AssignmentTeacherFragmentResponse> assignmentTeacherFragmentResponseCall = APIClient.getAssignmentService().upload(assignmentTeacherFragmentRequest);
        assignmentTeacherFragmentResponseCall.enqueue(new Callback<AssignmentTeacherFragmentResponse>() {
            @Override
            public void onResponse(Call<AssignmentTeacherFragmentResponse> call, Response<AssignmentTeacherFragmentResponse> response) {
                if (response.isSuccessful()){
                    Log.e("success", response.toString());
                    Toast.makeText(getContext(), "Successful", Toast.LENGTH_SHORT).show();

                }else{
                    Log.e("failed", response.toString());
                Toast.makeText(getContext(), "Failed", Toast.LENGTH_SHORT).show();

            }}

            @Override
            public void onFailure(Call<AssignmentTeacherFragmentResponse> call, Throwable t) {
                Log.e("this onFailure", t.toString());
                Toast.makeText(getContext(), "onFailure", Toast.LENGTH_SHORT).show();
            }
        });

    }
}