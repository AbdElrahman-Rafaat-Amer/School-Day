package com.example.schoolday.student;


import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentPagerAdapter;

public class PageAdapterProfStudent extends FragmentPagerAdapter {
    public PageAdapterProfStudent(FragmentManager fm) {
        super(fm);
    }


    @Override
    public Fragment getItem(int position) {

        switch (position) {
            case 0:
                ProfileStudentInfoFragment infoStudent = new ProfileStudentInfoFragment();
                return infoStudent;

            case 1:
                ProfileParentInfoFragment infoParent = new ProfileParentInfoFragment();
                return infoParent;

            case 2:
                ProfilePersonalInfoFragment infoPersonal = new ProfilePersonalInfoFragment();
                return infoPersonal;

            case 3:
                ProfileOtherInfoFragment infoOther = new ProfileOtherInfoFragment();
                return infoOther;
        }

        return null;
    }

    @Override
    public int getCount() {
        return 4;
    }
}
