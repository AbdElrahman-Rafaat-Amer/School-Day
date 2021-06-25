package com.example.schoolday.teacher.assignment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;


public class AssignmentTeacherFragment extends Fragment {
    ArrayList<AssignmentTeacher> assignmentTeachers = new ArrayList<>();
    AssignmentTeacherRecyclerViewAdapter adapter;
    RecyclerView recyclerView;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_assignment_teacher, container, false);
        recyclerView = view.findViewById(R.id.recyclerView_assignment_teacher);

        AssignmentTeacherInterface assignmentTeacherInterface = APIClient.getRetrofit().create(AssignmentTeacherInterface.class);
        assignmentTeacherInterface.getAssignmentTeacher().enqueue(new Callback<ArrayList<AssignmentTeacher>>() {
            @Override
            public void onResponse(Call<ArrayList<AssignmentTeacher>> call, Response<ArrayList<AssignmentTeacher>> response) {
                assignmentTeachers = response.body();

                adapter = new AssignmentTeacherRecyclerViewAdapter(getContext(),assignmentTeachers);
                recyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));
                recyclerView.setAdapter(adapter);
            }

            @Override
            public void onFailure(Call<ArrayList<AssignmentTeacher>> call, Throwable t) {
                Toast.makeText(getContext(), "There is problem", Toast.LENGTH_SHORT).show();
            }
        });
        return view;
    }
}