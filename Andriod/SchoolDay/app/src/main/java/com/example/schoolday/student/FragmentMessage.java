package com.example.schoolday.student;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.schoolday.R;
import com.getbase.floatingactionbutton.FloatingActionButton;

public class FragmentMessage extends Fragment {
    FloatingActionButton onlineFriends, createGroup;
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
         View view = inflater.inflate(R.layout.fragment_message,container,false);

         onlineFriends = view.findViewById(R.id.floatingbuttononline);
         createGroup = view.findViewById(R.id.floatingbuttoncreategroup);

         //this action to go to online page to see the online friends
         onlineFriends.setOnClickListener(new View.OnClickListener() {
             @Override
             public void onClick(View view) {
                 startActivity(new Intent( getContext(), OnlineFriendsActivity.class ));
             }
         });

        createGroup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
               // startActivity(new Intent( getContext(), OnlineFriendsActivity.class ));
            }
        });
        return view;
    }
}
