package com.example.schoolday;

import androidx.annotation.NonNull;
import androidx.appcompat.app.ActionBarDrawerToggle;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.viewpager.widget.ViewPager;

import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import com.etebarian.meowbottomnavigation.MeowBottomNavigation;
import com.google.android.material.navigation.NavigationView;
import com.google.android.material.tabs.TabLayout;


public class MainActivity extends AppCompatActivity  {
    MeowBottomNavigation meo;
    private final static int ID_HOME=3;
    private final static int ID_FEEDS=5;
    private  final static int ID_MESSAGES=2;
    private  final static int ID_TIMETABLE=1;
    private final static int ID_INFORMATION=4;
    ImageView notificationImage, searchImage, goBackChat;
    TextView currentFragment;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        goBackChat = findViewById(R.id.go_back_chat);
        notificationImage = findViewById(R.id.image_notification);
        searchImage = findViewById(R.id.image_search);
        currentFragment = findViewById(R.id.name_of_current_fragment);
        meo = findViewById(R.id.bottom_nav);





        // land scape
        if (savedInstanceState == null) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentHome()).commit();
        }


        //code for bottom nav bar
       meo.add(new MeowBottomNavigation.Model(1,R.drawable.ic_timetable));
        meo.add(new MeowBottomNavigation.Model(2,R.drawable.ic_messgaes));
        meo.add(new MeowBottomNavigation.Model(3,R.drawable.ic_home));
        meo.add(new MeowBottomNavigation.Model(4,R.drawable.ic_user_regular));
        meo.add(new MeowBottomNavigation.Model(5,R.drawable.ic_feeds));
        meo.setOnClickMenuListener(new MeowBottomNavigation.ClickListener() {
            @Override
            public void onClickItem(MeowBottomNavigation.Model item) {

            }
        });
        meo.setOnShowListener(new MeowBottomNavigation.ShowListener() {

            @Override
            public void onShowItem(MeowBottomNavigation.Model item) {

                switch (item.getId()){
                    case ID_HOME:
                        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new FragmentHome()).commit();
                        currentFragment.setText("");
                        searchImage.setVisibility(View.INVISIBLE);
                        break;
                    case ID_FEEDS:
                        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new FragmentFeed()).commit();
                        currentFragment.setText(R.string.feed);
                        searchImage.setVisibility(View.INVISIBLE);
                        break;
                    case ID_MESSAGES:
                        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new FragmentMessage()).commit();
                        currentFragment.setText(R.string.chat);
                        searchImage.setVisibility(View.VISIBLE);
                        break;
                    case ID_TIMETABLE:
                        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new FragmentTimetable()).commit();
                        searchImage.setVisibility(View.INVISIBLE);
                        break;
                    case ID_INFORMATION:
                        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new FragmentInformation()).commit();
                        currentFragment.setText(R.string.profile);
                        searchImage.setVisibility(View.INVISIBLE);
                        break;
                }
            }

        });
        meo.setOnReselectListener(new MeowBottomNavigation.ReselectListener() {
            @Override
            public void onReselectItem(MeowBottomNavigation.Model item) {
                //this method for solving problem of double click on icon
            }
        });

    }


}