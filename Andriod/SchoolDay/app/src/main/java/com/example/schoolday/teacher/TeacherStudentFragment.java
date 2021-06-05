package com.example.schoolday.teacher;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;


public class TeacherStudentFragment extends Fragment {
    Spinner acadimicYear,classYear;
    ArrayList<String> getYear = new ArrayList<String>();


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view =  inflater.inflate(R.layout.fragment_teacher_student, container, false);
        acadimicYear = view.findViewById(R.id.acadimic_year_spinner);
        classYear = view.findViewById(R.id.select_class_spinner);


        TeacherStudentInteface teacherStudentInteface = APIClient.getRetrofit().create(TeacherStudentInteface.class);
            teacherStudentInteface.getSelectYear().enqueue(new Callback<String>() {
                @Override
                public void onResponse(Call<String> call, Response<String> response) {
                    Log.i("Response",response.body().toString());
                    if (response.isSuccessful()){
                        if (response.body()!=null){
                            Log.i("success",response.body().toString());
                            try {
                                String  getResponse=response.body().toString();
                                List<TeacherStudentYear> getStudentYears = new ArrayList<TeacherStudentYear>();
                                JSONArray jsonArray = new JSONArray(getResponse);
                                getStudentYears.add(new TeacherStudentYear(-1,"select"));
                                for (int i =0 ; i<jsonArray.length();i++){
                                    TeacherStudentYear teacherStudentYear = new TeacherStudentYear();
                                    JSONObject jsonObject=jsonArray.getJSONObject(i);
                                    teacherStudentYear.setId(jsonObject.getInt("id"));
                                    teacherStudentYear.setName(jsonObject.getString("name"));
                                    getStudentYears.add(teacherStudentYear);
                                }
                                for (int i = 0; i<getStudentYears.size();i++){
                                    getYear.add(getStudentYears.get(i).getName().toString());
                                }
                                ArrayAdapter<String> spinStudentYear = new ArrayAdapter<String>(getContext(),R.layout.support_simple_spinner_dropdown_item,getYear);
                                spinStudentYear.setDropDownViewResource(R.layout.support_simple_spinner_dropdown_item);
                                acadimicYear.setAdapter(spinStudentYear);
                                acadimicYear.setOnItemClickListener(new AdapterView.OnItemClickListener() {
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