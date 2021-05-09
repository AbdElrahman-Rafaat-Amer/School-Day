package com.example.schoolday.student;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

import com.example.schoolday.R;

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

            }
        });

    }


}