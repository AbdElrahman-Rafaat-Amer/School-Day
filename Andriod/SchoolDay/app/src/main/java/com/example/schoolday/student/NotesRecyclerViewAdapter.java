package com.example.schoolday.student;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.R;

import java.util.ArrayList;

public class NotesRecyclerViewAdapter extends RecyclerView.Adapter<NotesRecyclerViewAdapter.NoteViewHolder> {

    Context context;
    ArrayList<Notes> notes;

    public NotesRecyclerViewAdapter(Context context, ArrayList<Notes> notes) {
        this.context = context;
        this.notes = notes;
    }


    @NonNull
    @Override
    public NoteViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.custom_row_notes, parent, false);
        NoteViewHolder noteViewHolder = new NoteViewHolder(view);
        return noteViewHolder;
    }

    @Override
    public void onBindViewHolder(@NonNull final NoteViewHolder holder, int position) {

        final Notes note = notes.get(position);
        holder.noteTitle.setText(note.getTitle());
        holder.noteDescription.setText(note.getText());
        holder.date.setText(note.getDateAndTime());
        holder.editNote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String date = note.getDateAndTime();
                String title = note.getTitle();
                String desc = note.getText();
              //  int id = note.getId();
                Toast.makeText(context, "id = "  + "\ntitle = " + title + "\ndesc = " + desc +
                        "\ndate = " + date, Toast.LENGTH_SHORT).show();
            }
        });

    }

    @Override
    public int getItemCount() {
        return notes.size();
    }

    public class NoteViewHolder extends RecyclerView.ViewHolder {
        TextView noteTitle, noteDescription, date;
        ImageView editNote;

        public NoteViewHolder(@NonNull View itemView) {
            super(itemView);

            noteDescription = itemView.findViewById(R.id.note_description);
            noteTitle = itemView.findViewById(R.id.note_title);
            date = itemView.findViewById(R.id.note_date_time);
            editNote = itemView.findViewById(R.id.edit_note);

        }
    }
}
