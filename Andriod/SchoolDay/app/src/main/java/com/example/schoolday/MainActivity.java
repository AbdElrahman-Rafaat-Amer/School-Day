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


public class MainActivity extends AppCompatActivity implements NavigationView.OnNavigationItemSelectedListener {
    /*MeowBottomNavigation meo;
    private final static int ID_HOME=3;
    private final static int ID_FEEDS=5;
    private  final static int ID_MESSAGES=2;
    private  final static int ID_TIMETABLE=1;
    private final static int ID_INFORMATION=4;*/
    private DrawerLayout drawer;
    NavigationView navigationView;
    Toolbar toolbar;
    ImageView notificationImage, searchImage, goBackChat;
    TextView currentFragment;
    TabLayout tabLayout;
    ViewPager viewPager;
    PageAdapter pageAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tabLayout = findViewById(R.id.tab);
        viewPager = findViewById(R.id.view);
        goBackChat = findViewById(R.id.go_back_chat);
        notificationImage = findViewById(R.id.image_notification);
        searchImage = findViewById(R.id.image_search);
        currentFragment = findViewById(R.id.name_of_current_fragment);
      //  meo = findViewById(R.id.bottom_nav);
        drawer = findViewById(R.id.drawer_layout);
        navigationView = findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);

        pageAdapter = new PageAdapter(getSupportFragmentManager());
        viewPager.setAdapter(pageAdapter);

        toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar,
                R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.addDrawerListener(toggle);
        toggle.syncState();

        if (savedInstanceState == null) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container, new FragmentHome()).commit();

        }

        tabLayout.addTab(tabLayout.newTab().setText("chat"));
        tabLayout.addTab(tabLayout.newTab().setText("timetable"));
        tabLayout.addTab(tabLayout.newTab().setText("home"));
        tabLayout.addTab(tabLayout.newTab().setText("profile"));
        tabLayout.addTab(tabLayout.newTab().setText("feed"));

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
        //code for bottom nav bar
       /* meo.add(new MeowBottomNavigation.Model(1,R.drawable.ic_timetable));
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
                        currentFragment.setText(R.string.timetable);
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
        });*/

    }

    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()) {
            case R.id.nav_teacher:
               getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_subject:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_assignment:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_notes:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_online_learning:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_exam:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_library:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_activity:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_attendance:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_bus:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_fees:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;

            case R.id.nav_downloads:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,new TeacherFragment()).commit();
                break;


        }

        drawer.closeDrawer(GravityCompat.START);
        return true;
    }

    @Override
    public void onBackPressed() {
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }
}