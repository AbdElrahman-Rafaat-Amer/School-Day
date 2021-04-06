package com.example.schoolday;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Switch;

public class NotesEditAddActivity extends AppCompatActivity {

    LinearLayout linearAddNote, linearEditNote;
    EditText editTitle, editDescription, addTitle, addDescription;
    Button save, update;
    String title , desc;
    static String click;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_notes_edit_add);

        linearAddNote = findViewById(R.id.linear_add_note);
        linearEditNote = findViewById(R.id.linear_edit_note);
        editDescription = findViewById(R.id.note_description_edit);
        editTitle = findViewById(R.id.note_title_edit);
        addTitle = findViewById(R.id.note_title_edit);
        addDescription = findViewById(R.id.note_description_add);
        save = findViewById(R.id.save_note);
        update = findViewById(R.id.update_note);

        Intent intent = getIntent();
         click = "switch";


        if (click.equals("switch")){
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
            update.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    title = editTitle.getText().toString();
                    desc = editDescription.getText().toString();

                }
            });

    }


}