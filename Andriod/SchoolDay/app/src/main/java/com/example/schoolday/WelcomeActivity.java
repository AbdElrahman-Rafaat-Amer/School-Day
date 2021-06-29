package com.example.schoolday;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;

import com.example.schoolday.parent.ParentHomeActivity;
import com.example.schoolday.student.FragmentHome;
import com.example.schoolday.student.MainActivity;
import com.example.schoolday.teacher.TeacherHomeFragment;

public class WelcomeActivity extends AppCompatActivity {
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_welcome);

        findViewById(R.id.welocome_button).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
           /*    Intent intent = new Intent(WelcomeActivity.this, MainActivity.class);
                intent.putExtra("from welcome to main student","Home");
               startActivity(intent);
*/
             Intent intent = new Intent(WelcomeActivity.this, MainActivity.class);
                   intent.putExtra("from welcome to main student","Home");
                   startActivity(intent);

            }
        });
    }
}