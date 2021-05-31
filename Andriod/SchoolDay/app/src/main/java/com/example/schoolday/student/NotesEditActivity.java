package com.example.schoolday.student;

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

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class NotesEditActivity extends AppCompatActivity {

    EditText editTitle, editDescription;
    Button update;
    String title, desc;
    int id;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_notes_edit);

        editDescription = findViewById(R.id.note_description_edit);
        editTitle = findViewById(R.id.note_title_edit);
        update = findViewById(R.id.update_note);
        Intent intent = getIntent();
        editDescription.setText(intent.getStringExtra("note desc"));
        editTitle.setText(intent.getStringExtra("note title"));
        id = intent.getIntExtra("note id",0);

        update.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                title = editTitle.getText().toString();
                desc = editDescription.getText().toString();
                saveNote(createRequest(title, desc, id));
            }
        });

    }

    public NoteRequest createRequest(String title, String desc, int id) {
        NoteRequest noteRequest = new NoteRequest();
        noteRequest.setText(desc);
        noteRequest.setTitle(title);
        noteRequest.setId(id);
        return noteRequest;
    }

    public void saveNote(NoteRequest noteRequest) {

        Call<NoteResponse> noteResponseCall = APIClient.getNoteService().saveNote(noteRequest);
        noteResponseCall.enqueue(new Callback<NoteResponse>() {
            @Override
            public void onResponse(Call<NoteResponse> call, Response<NoteResponse> response) {
                if (response.isSuccessful()){
                    Toast.makeText(NotesEditActivity.this, "Successful", Toast.LENGTH_SHORT).show();
                }else {
                    Log.e("failed",response.toString());
                    Toast.makeText(NotesEditActivity.this, "Failed", Toast.LENGTH_SHORT).show();
                }

            }

            @Override
            public void onFailure(Call<NoteResponse> call, Throwable t) {

                Toast.makeText(NotesEditActivity.this, "onFailure", Toast.LENGTH_SHORT).show();
                finish();
            }
        });
    }


}