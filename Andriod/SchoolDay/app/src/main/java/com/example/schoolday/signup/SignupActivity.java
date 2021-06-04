package com.example.schoolday.signup;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;
import com.example.schoolday.login.LoginActivity;
import com.example.schoolday.login.LoginResponse;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import com.example.schoolday.signup.Signup2Activity;

public class SignupActivity extends AppCompatActivity {

    private EditText name, email, password, confirmPassword;
    private TextView login;
    private RadioButton radioButtonParent, radioButtonTeacher, radioButtonStudent;
    private Button completingInfo;

    private String nameValue, emailValue, passwordValue, confirmPassValue;
    private boolean isParent, isStudent, isTeacher, isContinue;

    private static boolean check(String name, String email, String password, String confirmPass, boolean isStudent, boolean isTeacher, boolean isParent) {
        if (name.isEmpty() || email.isEmpty() || password.isEmpty() || confirmPass.isEmpty())
            return false;
        else if (isParent == false && isStudent == false && isTeacher == false)
            return false;
        else
            return true;

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.signup);

        name = findViewById(R.id.signup_name);
        email = findViewById(R.id.signup_mail);
        password = findViewById(R.id.signup_password);
        confirmPassword = findViewById(R.id.signup_confirmpassword);
        login = findViewById(R.id.moveto_login);
        completingInfo = findViewById(R.id.signup_compliting_info);
        radioButtonParent = findViewById(R.id.radio_parent);
        radioButtonTeacher = findViewById(R.id.radio_teacher);
        radioButtonStudent = findViewById(R.id.radio_student);

        login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(SignupActivity.this, LoginActivity.class));
            }
        });

        completingInfo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                nameValue = name.getText().toString();
                emailValue = email.getText().toString();
                passwordValue = password.getText().toString();
                confirmPassValue = confirmPassword.getText().toString();
                isParent = radioButtonParent.isChecked();
                isTeacher = radioButtonTeacher.isChecked();
                isStudent = radioButtonStudent.isChecked();

                isContinue = check(nameValue, emailValue, passwordValue, confirmPassValue, isStudent, isTeacher, isParent);

                if (isContinue == true) {
                    if (passwordValue.equals(confirmPassValue) && passwordValue.length() > 7) {
                        if (Patterns.EMAIL_ADDRESS.matcher(emailValue).matches()) {
                           // saveUser(createRequest());
                            startActivity(new Intent(SignupActivity.this, Signup2Activity.class));
                        } else {
                            AlertDialog.Builder builder = new AlertDialog.Builder(SignupActivity.this);
                            builder.setTitle(R.string.error)
                                    .setMessage(R.string.email_error)
                                    .setPositiveButton(R.string.ok, new DialogInterface.OnClickListener() {
                                        @Override
                                        public void onClick(DialogInterface dialog, int which) {
                                        }
                                    });
                            AlertDialog dialog = builder.create();
                            dialog.show();
                        }
                    } else {
                        AlertDialog.Builder builder = new AlertDialog.Builder(SignupActivity.this);
                        builder.setTitle(R.string.error)
                                .setMessage(R.string.password_error)
                                .setPositiveButton(R.string.ok, new DialogInterface.OnClickListener() {
                                    @Override
                                    public void onClick(DialogInterface dialog, int which) {
                                    }
                                });
                        AlertDialog dialog = builder.create();
                        dialog.show();
                    }
                } else {
                    AlertDialog.Builder builder = new AlertDialog.Builder(SignupActivity.this);
                    builder.setTitle(R.string.error)
                            .setMessage(R.string.empty_fields)
                            .setPositiveButton(R.string.ok, new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialog, int which) {
                                }
                            });
                    AlertDialog dialog = builder.create();
                    dialog.show();
                }


            }
        });

    }
        public void signup() {
            SignupRequest signupRequest = new SignupRequest();
            signupRequest.setFname(name.getText().toString());
            signupRequest.setEmail(email.getText().toString());
            signupRequest.setPassword(password.getText().toString());
            signupRequest.setConfirmPassword(confirmPassword.getText().toString());
            signupRequest.setRole(radioButtonParent.getText().toString());
            Call<SignupResponse> signupResponseCall = APIClient.getSignupService().signupUser(signupRequest);
            signupResponseCall.enqueue(new Callback<SignupResponse>() {
                @Override
                public void onResponse(Call<SignupResponse> call, Response<SignupResponse> response) {
                    if (response.isSuccessful()) {
                        Log.e("success", response.toString());
                        Toast.makeText(SignupActivity.this, "Successful", Toast.LENGTH_SHORT).show();
                        finish();
                    } else {
                        Log.e("failed", response.toString());
                        Toast.makeText(SignupActivity.this, "Failed", Toast.LENGTH_SHORT).show();
                    }
                }

                @Override
                public void onFailure(Call<SignupResponse> call, Throwable t) {
                    Log.e("this onFailure", t.toString());
                    Toast.makeText(SignupActivity.this, "onFailure", Toast.LENGTH_SHORT).show();
                    finish();
                }
            });
    }


}