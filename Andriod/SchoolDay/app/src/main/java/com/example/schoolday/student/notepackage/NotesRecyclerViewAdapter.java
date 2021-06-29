package com.example.schoolday.student.notepackage;

import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class NotesRecyclerViewAdapter extends RecyclerView.Adapter<NotesRecyclerViewAdapter.NoteViewHolder> {

    Context context;
    ArrayList<Notes> notes = new ArrayList<Notes>();

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
        holder.date.setText((CharSequence) note.getDate());
        holder.editNote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String date = note.getDate();
                String title = note.getTitle();
                String desc = note.getText();
                int id = note.getId();

                Intent intent = new Intent(context, NotesEditActivity.class);

                intent.putExtra("note date", date);
                intent.putExtra("note title", title);
                intent.putExtra("note desc", desc);
                intent.putExtra("note id", id);

                context.startActivity(intent);
            }
        });

    }

    @Override
    public int getItemCount() {
        return notes.size();

    }

    public class NoteViewHolder extends RecyclerView.ViewHolder {
        TextView noteTitle, date;
        ImageView editNote;

        public NoteViewHolder(@NonNull View itemView) {
            super(itemView);

            noteTitle = itemView.findViewById(R.id.note_title);
            date = itemView.findViewById(R.id.note_date_time);
            editNote = itemView.findViewById(R.id.edit_note);

        }


    }


}
