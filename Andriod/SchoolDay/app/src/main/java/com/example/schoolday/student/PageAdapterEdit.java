package com.example.schoolday.student;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentPagerAdapter;

public class PageAdapterEdit extends FragmentPagerAdapter {

    public PageAdapterEdit(@NonNull FragmentManager fm) {
        super(fm);
    }

    @NonNull
    @Override
    public Fragment getItem(int position) {
        switch (position){
            case 0: ProfileEditStudentFragment infoStudent = new ProfileEditStudentFragment();
                return infoStudent;

            case 1: ProfileEditParentFragment infoParent = new ProfileEditParentFragment();
                return infoParent;

            case 2: ProfileEditPersonalFragment infoPersonal = new ProfileEditPersonalFragment();
                return infoPersonal;

            case 3: ProfileEditOtherFragment infoOther = new ProfileEditOtherFragment();
                return infoOther;
        }

        return null;
    }

    @Override
    public int getCount() {
        return 4;
    }
}
