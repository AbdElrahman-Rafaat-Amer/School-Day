package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.viewpager.widget.ViewPager;

import com.example.schoolday.R;
import com.google.android.material.tabs.TabLayout;

public class FragmentAssignment extends Fragment {
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_assginment,container,false);
    }

    public static class EditActivity extends AppCompatActivity {

        TabLayout tabLayout;
        ViewPager viewPager;
        PageAdapterEdit pageAdapter;

        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_edit);

            tabLayout = findViewById(R.id.tab_page_edit);
            viewPager = findViewById(R.id.view_page_edit);

            pageAdapter = new PageAdapterEdit(getSupportFragmentManager());
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
}
