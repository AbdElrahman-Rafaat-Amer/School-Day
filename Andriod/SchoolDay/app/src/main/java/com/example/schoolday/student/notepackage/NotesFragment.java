package com.example.schoolday.student.notepackage;

import android.content.Intent;
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
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class NotesFragment extends Fragment {

    ArrayList<Notes> notes = new ArrayList<>();
    NotesRecyclerViewAdapter adapter;
    RecyclerView recyclerView;
    FloatingActionButton addNote;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_notes, container, false);
        recyclerView = view.findViewById(R.id.recyclerView_notes);
        addNote = view.findViewById(R.id.add_notes);

        addNote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent intent = new Intent(getContext(), NotesEditActivity.class);
                intent.putExtra("New Note", true);
                startActivity(intent);

            }
        });


        NoteInterface noteInterface = APIClient.getRetrofit().create(NoteInterface.class);

        noteInterface.getNote().enqueue(new Callback<ArrayList<Notes>>() {
            @Override
            public void onResponse(Call<ArrayList<Notes>> call, Response<ArrayList<Notes>> response) {
                notes = response.body();

                adapter = new NotesRecyclerViewAdapter(getContext(), notes);
                recyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));
                recyclerView.setAdapter(adapter);
            }

            @Override
            public void onFailure(Call<ArrayList<Notes>> call, Throwable t) {

                Toast.makeText(getContext(), "There is problem", Toast.LENGTH_SHORT).show();
            }
        });


        return view;
    }


    @Override
    public void onResume() {
        super.onResume();
        NoteInterface noteInterface = APIClient.getRetrofit().create(NoteInterface.class);
        noteInterface.getNote().enqueue(new Callback<ArrayList<Notes>>() {
            @Override
            public void onResponse(Call<ArrayList<Notes>> call, Response<ArrayList<Notes>> response) {
                notes = response.body();
                NotesRecyclerViewAdapter noteAdapter = new NotesRecyclerViewAdapter(getContext(), notes);
                recyclerView.setAdapter(noteAdapter);
            }

            @Override
            public void onFailure(Call<ArrayList<Notes>> call, Throwable t) {

            }
        });

    }
}