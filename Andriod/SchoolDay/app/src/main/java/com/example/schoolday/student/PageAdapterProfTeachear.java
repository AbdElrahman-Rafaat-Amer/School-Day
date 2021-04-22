package com.example.schoolday.student;


import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentPagerAdapter;

import com.example.schoolday.teacher.ProfileTeacherAssignmentFragment;

public class PageAdapterProfTeachear extends FragmentPagerAdapter {
    public PageAdapterProfTeachear(FragmentManager fm) {
        super(fm);
    }


    @Override
    public Fragment getItem(int position) {

        switch (position) {
            case 0:
                ProfileTeacherAssignmentFragment profileTeacherAssignmentFragment = new ProfileTeacherAssignmentFragment();
                return profileTeacherAssignmentFragment;

            case 1:
                ProfileTeacherTimeTableFragment profileTeacherTimeTableFragment = new ProfileTeacherTimeTableFragment();
                return profileTeacherTimeTableFragment;

            case 2:
                ProfileTeacherDegreeFragment profileTeacherDegreeFragment = new ProfileTeacherDegreeFragment();
                return profileTeacherDegreeFragment;

            case 3:
                ProfileTeacherPersonalInfoFragment infoFragment = new ProfileTeacherPersonalInfoFragment();
                return infoFragment;
        }

        return null;
    }

    @Override
    public int getCount() {
        return 4;
    }
}
