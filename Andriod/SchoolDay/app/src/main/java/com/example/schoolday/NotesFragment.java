package com.example.schoolday;

import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;

public class NotesFragment extends Fragment {

    RecyclerView  recyclerView ;
    NotesRecyclerViewAdapter adapter;
    ArrayList<Notes> notes = new ArrayList<>();

    FloatingActionButton addNote;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_notes, container, false);
        recyclerView = view.findViewById(R.id.recyclerView_notes);
        addNote = view.findViewById(R.id.add_notes);

        // intilise array list notes missed
        adapter = new NotesRecyclerViewAdapter(getContext(), notes);
        recyclerView.setLayoutManager(new LinearLayoutManager(getContext()));
        recyclerView.setAdapter(adapter);
        addNote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getContext(), NotesEditAddActivity.class);
                startActivity(intent);
            }
        });


        return view;
    }
}