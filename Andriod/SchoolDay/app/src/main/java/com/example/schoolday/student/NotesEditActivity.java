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
import com.example.schoolday.SignupActivity;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class NotesEditActivity extends AppCompatActivity {

    static String click;
    //  LinearLayout linearAddNote, linearEditNote;
    EditText editTitle, editDescription;//, addTitle, addDescription;
    Button update; //,save;
    String title, desc;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_notes_edit);

     /*   linearAddNote = findViewById(R.id.linear_add_note);
        linearEditNote = findViewById(R.id.linear_edit_note);

        addTitle = findViewById(R.id.note_title_edit);
        save = findViewById(R.id.save_note);
        addDescription = findViewById(R.id.note_description_add);
*/
        editDescription = findViewById(R.id.note_description_edit);
        editTitle = findViewById(R.id.note_title_edit);
        update = findViewById(R.id.update_note);
        Intent intent = getIntent();
        editDescription.setText(intent.getStringExtra("note desc"));
        editTitle.setText(intent.getStringExtra("note title"));


      /*  Intent intent = getIntent();
        click = "switch";
        if (click.equals("switch")) {
            linearEditNote.setVisibility(View.VISIBLE);
            linearAddNote.setVisibility(View.INVISIBLE);
            update.setVisibility(View.VISIBLE);
            save.setVisibility(View.INVISIBLE);

        }


        save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                title = addTitle.getText().toString();
                desc = addDescription.getText().toString();


            }
        });

        */

        update.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                title = editTitle.getText().toString();
                desc = editDescription.getText().toString();
                saveNote(createRequest());
            }
        });


    }


    public NoteRequest createRequest() {
        NoteRequest noteRequest = new NoteRequest();
        noteRequest.setText(editDescription.getText().toString());
        noteRequest.setTitle(editTitle.getText().toString());
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
            }
        });
    }


}