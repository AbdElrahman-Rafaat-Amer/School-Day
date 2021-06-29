package com.example.schoolday.parent;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;

import com.example.schoolday.R;
import com.example.schoolday.parent.feespackage.ParentFeesActivity;


public class ParentHomeActivity extends AppCompatActivity {

    private CardView parentProfile, studentProfile, exam, attendance, assignment, bus, fees;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_parent_home);

        parentProfile = findViewById(R.id.parent_card_profile);
        studentProfile = findViewById(R.id.parent_card_student);
        exam = findViewById(R.id.parent_card_exam);
        attendance = findViewById(R.id.parent_card_attendance);
        assignment = findViewById(R.id.parent_card_assignment);
        bus = findViewById(R.id.parent_card_bus);
        fees = findViewById(R.id.parent_card_fees);

        parentProfile.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(ParentHomeActivity.this, ParentProfileActivity.class));
            }
        });

        studentProfile.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(ParentHomeActivity.this, ParentStudentProfileActivity.class));
            }
        });

        attendance.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(ParentHomeActivity.this, ParentAttendanceActivity.class));
            }
        });

        assignment.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(ParentHomeActivity.this, ParentAssignmentActivity.class));
            }
        });

        exam.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(ParentHomeActivity.this, ParentExamActivity.class));
            }
        });

        bus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(ParentHomeActivity.this, ParentBusActivity.class));
            }
        });

        fees.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(ParentHomeActivity.this, ParentFeesActivity.class));
            }
        });
    }
}