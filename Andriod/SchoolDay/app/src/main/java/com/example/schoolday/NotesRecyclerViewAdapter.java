package com.example.schoolday;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class NotesRecyclerViewAdapter extends RecyclerView.Adapter<NotesRecyclerViewAdapter.NoteViewHolder> {
    Context context;
    ArrayList<Notes> notes = new ArrayList<>();
    static final String click = "Activity Name";

    public NotesRecyclerViewAdapter(Context context, ArrayList<Notes> notes) {
        this.context = context;
        this.notes = notes;
    }

    @NonNull
    @Override
    public NoteViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        return new NoteViewHolder(LayoutInflater.from(parent.getContext()).inflate(R.layout.custom_row_notes,parent,false));
    }

    @Override
    public void onBindViewHolder(@NonNull final NoteViewHolder holder, int position) {

        final Notes note = notes.get(position);
        holder.noteTitle.setText(note.getTitle());
        holder.noteDescription.setText(note.getDescription());
        holder.date.setText(note.getDateAndTime());
        holder.editNote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String title = note.getTitle();
                String description = note.getDescription();

                Intent intent = new Intent(context, NotesEditAddActivity.class);
                intent.putExtra("TITLE", title);
                intent.putExtra("DESCRIPTION", description);

                context.startActivity(intent);
            }
        });
    }

    @Override
    public int getItemCount() {
        return notes.size();
    }

    public class NoteViewHolder extends RecyclerView.ViewHolder {
        TextView noteTitle, noteDescription, date;
        ImageView   editNote;
        public NoteViewHolder(@NonNull View itemView) {
            super(itemView);

            noteDescription = itemView.findViewById(R.id.note_description);
            noteTitle = itemView.findViewById(R.id.note_title);
            date = itemView.findViewById(R.id.note_date_time);
            editNote = itemView.findViewById(R.id.edit_note);

        }
    }
}
