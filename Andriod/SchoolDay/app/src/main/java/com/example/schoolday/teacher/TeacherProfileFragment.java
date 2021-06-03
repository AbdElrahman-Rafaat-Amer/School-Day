package com.example.schoolday.teacher;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.viewpager.widget.ViewPager;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.schoolday.student.PageAdapterProfTeachear;
import com.example.schoolday.R;
import com.google.android.material.tabs.TabLayout;

public class TeacherProfileFragment extends Fragment {


    TabLayout tabLayout;
    ViewPager viewPager;
    PageAdapterProfTeachear pageAdapter;


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_teacher_profile, container, false);

        tabLayout = view.findViewById(R.id.tabslayoutteacher);
        viewPager = view.findViewById(R.id.viewpagerTeacher);

        pageAdapter = new PageAdapterProfTeachear(getChildFragmentManager());
        viewPager.setAdapter(pageAdapter);

        tabLayout.addTab(tabLayout.newTab().setText("Assignment"));
        tabLayout.addTab(tabLayout.newTab().setText("Time Table"));
        tabLayout.addTab(tabLayout.newTab().setText("Degree"));
        tabLayout.addTab(tabLayout.newTab().setText("Personal info"));

        viewPager.addOnPageChangeListener(new TabLayout.TabLayoutOnPageChangeListener(tabLayout));

        tabLayout.addOnTabSelectedListener(new TabLayout.OnTabSelectedListener() {
            @Override
            public void onTabSelected(TabLayout.Tab tab) {
                viewPager.setCurrentItem(tab.getPosition());
            }

            @Override
            public void onTabUnselected(TabLayout.Tab tab) {

            }

            @Override
            public void onTabReselected(TabLayout.Tab tab) {

            }
        });
        return view;
    }
}