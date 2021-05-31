package com.example.schoolday.student;

import android.app.AlertDialog;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
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

    Notes noteDetails;
    ArrayList<Notes> notes = new ArrayList<>();
    NotesRecyclerViewAdapter adapter;
    RecyclerView recyclerView;
    FloatingActionButton addNote;
    private AlertDialog.Builder builder;
    private AlertDialog alertDialog;
    private Button saveNote;
    private EditText noteTitle, noteContent;
    private String title, content;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_notes, container, false);
        recyclerView = view.findViewById(R.id.recyclerView_notes);
        addNote = view.findViewById(R.id.add_notes);

        addNote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                addDialogNote();
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


    private void addDialogNote() {
        View view = getLayoutInflater().inflate(R.layout.addnote_menu, null);
        noteTitle = view.findViewById(R.id.title_add_note);
        noteContent = view.findViewById(R.id.content_add_note);
        saveNote = view.findViewById(R.id.save_note);

        builder = new AlertDialog.Builder(getContext());
        builder.setView(view);
        alertDialog = builder.create();
        alertDialog.show();

        saveNote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                title = noteTitle.getText().toString();
                content = noteContent.getText().toString();
                if (title.isEmpty() || content.isEmpty())
                    Toast.makeText(getContext(), R.string.empty_erro, Toast.LENGTH_SHORT).show();
                else {
                    noteDetails = new Notes(title, content);
                    /// here code post to server
                    alertDialog.dismiss();
                }
            }
        });
    }
/*
    private void deleteDialogNote(NoteDetails noteDetails) {

        builder = new AlertDialog.Builder(MainActivity.this)
                .setTitle(R.string.title_delete)
                .setMessage(R.string.ask_delete)
                .setPositiveButton(R.string.ok, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                        int id = noteDetails.getId();
                        dateBaseHelper.deleteNote(id);
                        onResume();
                    }
                }).setNegativeButton(R.string.cancle, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                        alertDialog.dismiss();
                    }
                });
        alertDialog = builder.create();
        alertDialog.show();
    }
*/

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