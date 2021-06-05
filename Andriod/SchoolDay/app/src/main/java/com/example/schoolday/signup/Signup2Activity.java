package com.example.schoolday.signup;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.example.schoolday.R;
import com.example.schoolday.WelcomeActivity;

public class Signup2Activity extends AppCompatActivity {

    private EditText phoneNumber;
    private EditText middleName;
    private EditText nationalID;
    private EditText lastName;
    private EditText licenceId;
    private RadioButton radioButtonMale, radioButtonFemale;
    private Button signUp;

    private String firstNumberValue, middleNameValue, nationalIDValue, lastNameValue,licenceIdValue;
    private boolean isMale, isFemale, isContinue;

    private static boolean check(String middleName, String lastName, String nationalID, String phoneNumber,String licenceId, boolean isMale, boolean isFemale) {
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
                isContinue = check(firstNumberValue, middleNameValue, nationalIDValue, lastNameValue , licenceIdValue, isFemale, isMale);

                if (isContinue == true) {

                    //check if the phone is right or not
                    if (Patterns.PHONE.matcher(firstNumberValue).matches() && firstNumberValue.length() == 11 ) {

                        //check if the nationalID is right or not
                        if (nationalIDValue.length() == 18)
                            startActivity(new Intent(Signup2Activity.this, WelcomeActivity.class));
                        else {
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
}