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

public class FragmentInformation extends Fragment  {

    ImageView notification, edit, moreOption;
    TabLayout tabLayout;
    ViewPager viewPager;
    PageAdapterProfStudent pageAdapter;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_information, container, false);

        tabLayout = view.findViewById(R.id.tab_page);
        viewPager = view.findViewById(R.id.view_page);

        pageAdapter = new PageAdapterProfStudent(getFragmentManager());
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

        /*
        edit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getContext(), EditActivity.class);
                startActivity(intent);
            }
        });

        moreOption.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                popupMenuShow(v);
            }
        });
*/
        return view;
    }

    /*
    private void popupMenuShow(View v) {
        PopupMenu popupMenu = new PopupMenu(getContext() , v);
        popupMenu.setOnMenuItemClickListener(this);
        popupMenu.inflate(R.menu.more_actions);
        popupMenu.show();
    }


    @Override
    public boolean onMenuItemClick(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.log_out:
                Toast.makeText(getContext(), "you pressed logout", Toast.LENGTH_SHORT).show();
                return true;


            case R.id.dark_mode:

                if (AppCompatDelegate.getDefaultNightMode() == AppCompatDelegate.MODE_NIGHT_YES) {
                    AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);
                } else {
                    AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);

                }
                return true;

        }
        return true;
    }
    */
}
