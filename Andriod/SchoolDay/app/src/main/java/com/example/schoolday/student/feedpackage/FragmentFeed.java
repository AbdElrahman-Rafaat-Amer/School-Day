package com.example.schoolday.student.feedpackage;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.R;
import com.example.schoolday.student.feedpackage.AddFeedActivity;
import com.example.schoolday.student.notepackage.NotesRecyclerViewAdapter;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

public class FragmentFeed extends Fragment {
    NotesRecyclerViewAdapter adapter;
    RecyclerView recyclerView;
    FloatingActionButton addFeed;
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

       View view = inflater.inflate(R.layout.fragment_feed,container,false);
        recyclerView = view.findViewById(R.id.recyclerView_feed);
        addFeed = view.findViewById(R.id.add_feed);
        addFeed.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent intent = new Intent(getContext(), AddFeedActivity.class);
                startActivity(intent);

            }
        });


        return view;
    }
}
