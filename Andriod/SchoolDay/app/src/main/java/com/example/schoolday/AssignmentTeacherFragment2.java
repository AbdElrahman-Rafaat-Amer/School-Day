package com.example.schoolday;

import android.content.Context;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import com.example.schoolday.teacher.AssignmentTeacherInterface;
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
Spinner subjectName,className;
    ArrayList<String> getSubjectArr = new ArrayList<String>();
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view= inflater.inflate(R.layout.fragment_assignment_teacher2, container, false);
subjectName= view.findViewById(R.id.subjet_name_spinner);
className = view.findViewById(R.id.select_class_spinner);

        AssignmentTeacherInterface assignmentTeacherInterface = APIClient.getRetrofit().create(AssignmentTeacherInterface.class);
        assignmentTeacherInterface.getListYear().enqueue(new Callback<String>() {
            @Override
          public void onResponse(Call<String> call, Response<String> response) {
                Log.i("Response",response.body().toString());
                if (response.isSuccessful()){
                    if (response.body()!=null){
                        Log.i("success",response.body().toString());
                        try {
                            String  getResponse=response.body().toString();
                            List<AssignmentTeacherSubject> getSubject = new ArrayList<>();
                            JSONArray jsonArray = new JSONArray(getResponse);
                            getSubject.add(new AssignmentTeacherSubject(-1,"select"));
                            for (int i =0 ; i<jsonArray.length();i++){
                                AssignmentTeacherSubject assignmentTeacherSubject = new AssignmentTeacherSubject();
                                JSONObject jsonObject=jsonArray.getJSONObject(i);
                                assignmentTeacherSubject.setYearId(jsonObject.getInt("id"));
                                assignmentTeacherSubject.setYearName(jsonObject.getString("name"));
                                getSubject.add(assignmentTeacherSubject);
                            }
                            for (int i = 0; i<getSubject.size();i++){
                                getSubjectArr.add(getSubject.get(i).getYearName().toString());
                            }
                            ArrayAdapter<String> spinSubject = new ArrayAdapter<String>(getContext(),R.layout.support_simple_spinner_dropdown_item,getSubjectArr);
                            spinSubject.setDropDownViewResource(R.layout.support_simple_spinner_dropdown_item);
                            subjectName.setAdapter(spinSubject);
                            subjectName.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                                @Override
                                public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                                }
                            });
                        }
                        catch (JSONException exception){
                            exception.printStackTrace();
                        }
                    }
                }
            }


            @Override
            public void onFailure(Call<String> call, Throwable t) {

            }
        });


        return view;
    }
}