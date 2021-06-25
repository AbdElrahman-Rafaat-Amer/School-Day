package com.example.schoolday.teacher;

import android.os.Bundle;

import androidx.cardview.widget.CardView;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.schoolday.R;
import com.example.schoolday.student.FragmentLiberary;
import com.example.schoolday.student.notepackage.NotesFragment;
import com.example.schoolday.teacher.assignment.AssignmentTeacherFragment;


public class TeacherHomeFragment extends Fragment {
    CardView teacherCard,subjectCard,assignmentCard,notesCard,onlineCard,examCard,libraryCard,activityCard,attendanceCard;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_teacher_home, container, false);

        teacherCard=view.findViewById(R.id.teacher_card_home);
        subjectCard=view.findViewById(R.id.subject_card_home);
        assignmentCard=view.findViewById(R.id.assignment_card_home);
        notesCard=view.findViewById(R.id.notes_card_home);
        onlineCard=view.findViewById(R.id.online_card_home);
        examCard=view.findViewById(R.id.exam_card_home);
        libraryCard=view.findViewById(R.id.library_card_home);
        activityCard=view.findViewById(R.id.activity_card_home);
        attendanceCard=view.findViewById(R.id.attendance_card_home);

        teacherCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new TeacherProfileFragment()).commit();
            }
        });
        subjectCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new TeacherSubjectFragment()).commit();
            }
        });
        assignmentCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new AssignmentTeacherFragment()).commit();
            }
        });

        notesCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new NotesFragment()).commit();
            }
        });

            examCard.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new ExamTeacherFragment()).commit();
                }
            });

            libraryCard.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentLiberary()).commit();
                }
            });
           attendanceCard.setOnClickListener(new View.OnClickListener() {
               @Override
               public void onClick(View v) {
                   getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new AttendanceTeacherFragment()).commit();
               }
           });

        return view;
    }
}