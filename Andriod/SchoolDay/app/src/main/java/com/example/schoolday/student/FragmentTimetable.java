package com.example.schoolday.student;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.DatePicker;
import android.widget.FrameLayout;
import android.widget.ScrollView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.schoolday.R;
import com.vivekkaushik.datepicker.DatePickerTimeline;
import com.vivekkaushik.datepicker.OnDateSelectedListener;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;

public class    FragmentTimetable extends Fragment {
    private static final String TAG = "MainActivity";
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_timetable,container,false);
        final FrameLayout frameLayout = view.findViewById(R.id.fid);
        DatePickerTimeline datePickerTimeline = view.findViewById(R.id.dateTimeline);
        datePickerTimeline.setInitialDate(2019, 10, 12);
        java.util.Calendar date = java.util.Calendar.getInstance();
        date.add(java.util.Calendar.DAY_OF_YEAR, 5);
        datePickerTimeline.setActiveDate(date);
        datePickerTimeline.setOnDateSelectedListener(new OnDateSelectedListener() {
            @SuppressLint("ResourceAsColor")
            @Override
            public void onDateSelected(int year, int month, int day, int dayOfWeek) {
                //Do Something
                Log.d(TAG, "onDateSelected: " + day);
                frameLayout.setBackgroundColor(R.color.colorPrimaryDark);
            }

            @Override
            public void onDisabledDateSelected(int year, int month, int day, int dayOfWeek, boolean isDisabled) {
                Log.d(TAG, "onDisabledDateSelected: " + day);
            }
        });

        Date[] dates = {Calendar.getInstance().getTime()};
        datePickerTimeline.deactivateDates(dates);

         return view;
    }
}
