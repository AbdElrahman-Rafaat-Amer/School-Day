package com.example.schoolday.student.notepackage;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;

import java.util.Calendar;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class NotesEditActivity extends AppCompatActivity {

    private EditText editTitle, editDescription;
    private Button update;
    private String currentTitle, currentDesc, title, desc, date;
    private int id;
    private boolean isNew;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_notes_edit);

        editDescription = findViewById(R.id.note_description_edit);
        editTitle = findViewById(R.id.note_title_edit);
        update = findViewById(R.id.update_note);
        Calendar c = Calendar.getInstance();
        date = c.toString();

        isNew = getIntent().getBooleanExtra("New Note", false);
        if (isNew) {
            update.setText(R.string.save);
            update.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    title = editTitle.getText().toString();
                    desc = editDescription.getText().toString();
                    saveNote(createRequest());
                }
            });

        } else {
            Intent intent = getIntent();
            editDescription.setText(intent.getStringExtra("note desc"));
            editTitle.setText(intent.getStringExtra("note title"));
            id = intent.getIntExtra("note id", 0);
            update.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    currentTitle = editTitle.getText().toString();
                    currentDesc = editDescription.getText().toString();
                    saveNote(updateRequest(currentTitle, currentDesc, id/*, date*/));
                }
            });
        }


    }

    public Notes updateRequest(String title, String desc, int id/*, String date*/) {
        Notes noteRequest = new Notes();
        noteRequest.setText(desc);
        noteRequest.setTitle(title);
        noteRequest.setId(id);
        // noteRequest.setDate(date);
        return noteRequest;
    }

    public Notes createRequest() {
        Notes noteRequest = new Notes();
        noteRequest.setText(desc);
        noteRequest.setTitle(title);
        //  noteRequest.setDate(date);
        return noteRequest;
    }

    public void saveNote(Notes note) {

        Call<Void> notesCall = APIClient.getNoteService().saveNote(note);
        notesCall.enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Log.e("success", response.toString());
                    Toast.makeText(NotesEditActivity.this, "Successful", Toast.LENGTH_SHORT).show();
                    finish();
                } else {
                    Log.e("failed", response.toString());
                    Toast.makeText(NotesEditActivity.this, "Failed", Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Log.e("this onFailure", t.toString());
                Toast.makeText(NotesEditActivity.this, "onFailure", Toast.LENGTH_SHORT).show();
                finish();
            }
        });

    }


}