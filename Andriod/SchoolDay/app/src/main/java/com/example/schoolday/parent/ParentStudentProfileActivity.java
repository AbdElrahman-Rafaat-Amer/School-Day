package com.example.schoolday.parent;

import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;
import androidx.viewpager.widget.ViewPager;

import com.example.schoolday.R;
import com.example.schoolday.student.PageAdapterProfStudent;
import com.google.android.material.tabs.TabLayout;


public class ParentStudentProfileActivity extends AppCompatActivity {
    TabLayout tabLayout;
    ViewPager viewPager;
    PageAdapterProfStudent pageAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_parent_student_profile);

        tabLayout = findViewById(R.id.parent_tab_page);
        viewPager = findViewById(R.id.parent_view_page);

        pageAdapter = new PageAdapterProfStudent(getSupportFragmentManager());
        viewPager.setAdapter(pageAdapter);

        tabLayout.addTab(tabLayout.newTab().setText("student info"));
        tabLayout.addTab(tabLayout.newTab().setText("parent info"));
        tabLayout.addTab(tabLayout.newTab().setText("personal info"));
        tabLayout.addTab(tabLayout.newTab().setText("other info"));

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
    }
}