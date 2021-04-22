package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.R;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class NotesFragment extends Fragment {

    String link = "http://nabilhelmy313-001-site2.htempurl.com/Note";
    ArrayList<Notes> notes = new ArrayList<>();
    NotesRecyclerViewAdapter adapter;
    RecyclerView  recyclerView ;
    FloatingActionButton addNote;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_notes, container, false);
        recyclerView = view.findViewById(R.id.recyclerView_notes);
        addNote = view.findViewById(R.id.add_notes);

        Retrofit retrofit = new Retrofit.Builder().baseUrl("https://www.simplifiedcoding.net/demos/")
                .addConverterFactory(GsonConverterFactory.create()).build();

        NoteInterface noteInterface = retrofit.create(NoteInterface.class);

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
}