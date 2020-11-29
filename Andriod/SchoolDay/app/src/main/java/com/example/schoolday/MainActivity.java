package com.example.schoolday;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Toast;

import com.etebarian.meowbottomnavigation.MeowBottomNavigation;



public class MainActivity extends AppCompatActivity {
    MeowBottomNavigation meo;
    private final static int ID_HOME=3;
    private final static int ID_FEEDS=5;
    private  final static int ID_MESSAGES=2;
    private  final static int ID_TIMETABLE=1;
    private final static int ID_INFORMATION=4;




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        meo=findViewById(R.id.bottom_nav);
        meo.add(new MeowBottomNavigation.Model(1,R.drawable.ic_timetable));
        meo.add(new MeowBottomNavigation.Model(2,R.drawable.ic_messgaes));
        meo.add(new MeowBottomNavigation.Model(3,R.drawable.ic_home));
        meo.add(new MeowBottomNavigation.Model(4,R.drawable.ic_user_regular));
        meo.add(new MeowBottomNavigation.Model(5,R.drawable.ic_feeds));
        meo.setOnClickMenuListener(new MeowBottomNavigation.ClickListener() {
            @Override
            public void onClickItem(MeowBottomNavigation.Model item) {
                Toast.makeText(MainActivity.this, "Clicked item"+item.getId(), Toast.LENGTH_SHORT).show();
            }
        });
        meo.setOnShowListener(new MeowBottomNavigation.ShowListener() {

            @Override
            public void onShowItem(MeowBottomNavigation.Model item) {
                Fragment select_fragment=null;
                switch (item.getId()){
                    case ID_HOME:
                          select_fragment=new FragmentHome();
                        break;
                    case ID_FEEDS:
                        select_fragment=new FragmentFeed();
                        break;
                    case ID_MESSAGES:
                        select_fragment=new FragmentMessage();
                        break;
                    case ID_TIMETABLE:
                        select_fragment=new FragmentTimetable();
                        break;
                    case ID_INFORMATION:
                        select_fragment=new FragmentInformation();
                        break;
                }
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,select_fragment).commit();


            }

            });
        meo.setOnReselectListener(new MeowBottomNavigation.ReselectListener() {
            @Override
            public void onReselectItem(MeowBottomNavigation.Model item) {

                Toast.makeText(MainActivity.this, "Clicked item"+item.getId(), Toast.LENGTH_SHORT).show();
            }
        });

    }

}