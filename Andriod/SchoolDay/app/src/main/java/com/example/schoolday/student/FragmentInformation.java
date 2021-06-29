package com.example.schoolday.student;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.viewpager.widget.ViewPager;

import com.example.schoolday.R;
import com.google.android.material.tabs.TabLayout;

public class FragmentInformation extends Fragment {


    TabLayout tabLayout;
    ViewPager viewPager;
    PageAdapterProfStudent pageAdapter;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_information, container, false);

        tabLayout = view.findViewById(R.id.tab_page);
        viewPager = view.findViewById(R.id.view_page);

        pageAdapter = new PageAdapterProfStudent(getChildFragmentManager());
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

        return view;
    }

}
