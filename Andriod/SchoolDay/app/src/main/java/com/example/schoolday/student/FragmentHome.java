package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.OnBackPressedCallback;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.cardview.widget.CardView;
import androidx.fragment.app.Fragment;

import com.example.schoolday.R;
import com.example.schoolday.student.downloadspackage.DownloadFragment;
import com.example.schoolday.student.feespackage.FragmentFees;
import com.example.schoolday.student.notepackage.NotesFragment;

public class FragmentHome extends Fragment {

    ImageView studentImage;
    TextView studentName;
    CardView teacherCard, subjectCard, assignmentCard, notesCard, onlineCard, examCard, libraryCard,
                activityCard, attendanceCard, busCard, feesCard, downloadsCard;
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_home,container,false);



        studentImage = view.findViewById(R.id.student_profile_image);
        studentName = view.findViewById(R.id.student_name_home);
        teacherCard = view.findViewById(R.id.teacher_card_home);
        subjectCard = view.findViewById(R.id.subject_card_home);
        assignmentCard = view.findViewById(R.id.assignment_card_home);
        notesCard = view.findViewById(R.id.notes_card_home);
        onlineCard = view.findViewById(R.id.online_card_home);
        examCard = view.findViewById(R.id.exam_card_home);
        libraryCard = view.findViewById(R.id.library_card_home);
        activityCard = view.findViewById(R.id.activity_card_home);
        attendanceCard = view.findViewById(R.id.attendance_card_home);
        busCard = view.findViewById(R.id.bus_card_home);
        feesCard = view.findViewById(R.id.fees_card_home);
        downloadsCard = view.findViewById(R.id.download_card_home);

        teacherCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new TeacherFragment()).commit();
            }
        });
        subjectCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                FragmentSubjects subjects = new FragmentSubjects();
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, subjects).commit();
            }
        });
        assignmentCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentAssignment()).commit();
            }
        });


        notesCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new NotesFragment()).commit();
            }
        });
        onlineCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentOnline()).commit();
            }
        });
        examCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentExams()).commit();
            }
        });



        libraryCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentLiberary()).commit();
            }
        });
        activityCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               /// startActivity(new Intent(getContext(),TeacherFragment.class));
            }
        });
        attendanceCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               // startActivity(new Intent(getContext(),TeacherFragment.class));
            }
        });


        busCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               // startActivity(new Intent(getContext(),TeacherFragment.class));
            }
        });
        feesCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentFees()).commit();
            }
        });
        downloadsCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getActivity().getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new DownloadFragment()).commit();
            }
        });

        return view;
    }

}
