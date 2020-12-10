package com.example.schoolday;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentPagerAdapter;

public class PageAdapter extends FragmentPagerAdapter {
    public PageAdapter(@NonNull FragmentManager fm) {
        super(fm);
    }

    @NonNull
    @Override
    public Fragment getItem(int position) {

        switch (position){
            case 0: FragmentMessage  fragmentMessage = new FragmentMessage();
                return fragmentMessage;

            case 1: FragmentTimetable fragmentTimetable = new FragmentTimetable();
                return fragmentTimetable;

            case 2: FragmentHome fragmentHome = new FragmentHome();
                return fragmentHome;

            case 3: FragmentInformation fragmentInformation = new FragmentInformation();
                return fragmentInformation;

            case 4: FragmentFeed fragmentFeed = new FragmentFeed();
                return fragmentFeed;

        }

        return null;
    }

    @Override
    public int getCount() {
        return 5;
    }
}
