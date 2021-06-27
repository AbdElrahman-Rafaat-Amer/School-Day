package com.example.schoolday.teacher.assignment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.cardview.widget.CardView;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.R;

import java.util.ArrayList;


public class AssignmentTeacherFragment extends Fragment {
    ArrayList<AssignmentTeacher> assignmentTeachers = new ArrayList<>();
    AssignmentTeacherRecyclerViewAdapter adapter;
    RecyclerView recyclerView;
    CardView pdfAssignment;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_assignment_teacher, container, false);
        recyclerView = view.findViewById(R.id.recyclerView_assignment_teacher);
        pdfAssignment = view.findViewById(R.id.pdf_assignment);
        pdfAssignment.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new AssignmentTeacherFragment2()).commit();
            }
        });
      /*  AssignmentTeacherInterface assignmentTeacherInterface = APIClient.getRetrofit().create(AssignmentTeacherInterface.class);
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
        });*/
        return view;
    }
}