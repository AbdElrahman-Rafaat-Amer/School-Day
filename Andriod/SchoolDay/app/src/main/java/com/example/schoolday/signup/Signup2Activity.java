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
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;
import com.example.schoolday.WelcomeActivity;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Signup2Activity extends AppCompatActivity {

    private EditText phoneNumber;
    private EditText middleName;
    private EditText nationalID;
    private EditText lastName;
    private EditText licenceId;
    private RadioButton radioButtonMale, radioButtonFemale;
    private Button signUp;

    private String firstNumberValue, middleNameValue, nationalIDValue, lastNameValue, licenceIdValue,gender;
    private boolean isMale, isFemale, isContinue,isResponse;
    private String nameValue, emailValue, passwordValue, confirmPassValue, role;


    private static boolean check(String middleName, String lastName, String nationalID, String phoneNumber, String licenceId, boolean isMale, boolean isFemale) {
        if (middleName.isEmpty() || lastName.isEmpty() || nationalID.isEmpty() || phoneNumber.isEmpty() || licenceId.isEmpty())
            return false;
        else if (isMale == false && isFemale == false)
            return false;
        else
            return true;

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_signup2);

        phoneNumber = findViewById(R.id.first_phone_number_signup);
        middleName = findViewById(R.id.signup_name2);
        nationalID = findViewById(R.id.national_identity_number_signUp);
        lastName = findViewById(R.id.signup_name3);
        licenceId = findViewById(R.id.licence_id);
        signUp = findViewById(R.id.signup_button);
        radioButtonMale = findViewById(R.id.radio_male);
        radioButtonFemale = findViewById(R.id.radio_female);

        signUp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                firstNumberValue = phoneNumber.getText().toString();
                middleNameValue = middleName.getText().toString();
                nationalIDValue = nationalID.getText().toString();
                lastNameValue = lastName.getText().toString();
                licenceIdValue = licenceId.getText().toString();
                isMale = radioButtonMale.isChecked();
                isFemale = radioButtonFemale.isChecked();

                //check if the fields empty or not
                isContinue = check(firstNumberValue, middleNameValue, nationalIDValue, lastNameValue, licenceIdValue, isFemale, isMale);

                if (isContinue == true) {

                    //check if the phone is right or not
                    if (Patterns.PHONE.matcher(firstNumberValue).matches() && firstNumberValue.length() == 11) {

                        //check if the nationalID is right or not
                        if (nationalIDValue.length() == 14) {

                            Intent intent = new Intent(Signup2Activity.this, WelcomeActivity.class);
                            nameValue = intent.getStringExtra("signup_name");
                            emailValue = intent.getStringExtra("signup_email");
                            passwordValue = intent.getStringExtra("signup_password");
                            confirmPassValue = intent.getStringExtra("signup_confirm_password");
                            role = intent.getStringExtra("signup_role");
                            if (isMale==true){
                                gender="male";
                            }else if (isFemale==true){
                                gender="female";
                            }
                            signup();
                            if(isResponse==true){
                                startActivity(intent);
                            }

                        } else {
                            AlertDialog.Builder builder = new AlertDialog.Builder(Signup2Activity.this);
                            builder.setTitle(R.string.error)
                                    .setMessage(R.string.national_error)
                                    .setPositiveButton(R.string.ok, new DialogInterface.OnClickListener() {
                                        @Override
                                        public void onClick(DialogInterface dialog, int which) {
                                        }
                                    });
                            AlertDialog dialog = builder.create();
                            dialog.show();
                        }
                    } else {
                        AlertDialog.Builder builder = new AlertDialog.Builder(Signup2Activity.this);
                        builder.setTitle(R.string.error)
                                .setMessage(R.string.phone_error)
                                .setPositiveButton(R.string.ok, new DialogInterface.OnClickListener() {
                                    @Override
                                    public void onClick(DialogInterface dialog, int which) {
                                    }
                                });
                        AlertDialog dialog = builder.create();
                        dialog.show();
                    }
                } else {
                    AlertDialog.Builder builder = new AlertDialog.Builder(Signup2Activity.this);
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
        signupRequest.setFname(nameValue);
        signupRequest.setEmail(emailValue);
        signupRequest.setPassword(passwordValue);
        signupRequest.setConfirmPassword(confirmPassValue);
        signupRequest.setRole(role);
        signupRequest.setGender(gender);
        signupRequest.setMname(middleNameValue);
        signupRequest.setLname(lastNameValue);
        signupRequest.setPhone_1(firstNumberValue);
        signupRequest.setLicenseID(licenceIdValue);
        signupRequest.setNationalID(nationalIDValue);
        Call<Void> signupResponseCall = APIClient.getSignupService().signupUser(signupRequest);
        signupResponseCall.enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Log.e("success", response.toString());
                    Toast.makeText(Signup2Activity.this, "Successful", Toast.LENGTH_SHORT).show();
                    finish();
                    isResponse=true;
                } else {
                    Log.e("failed", response.toString());
                    Toast.makeText(Signup2Activity.this, "Failed", Toast.LENGTH_SHORT).show();
                    isResponse=false;
                }
            }

            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Log.e("this onFailure", t.toString());
                Toast.makeText(Signup2Activity.this, "onFailure", Toast.LENGTH_SHORT).show();
                finish();
                isResponse=false;
            }
        });
    }
}