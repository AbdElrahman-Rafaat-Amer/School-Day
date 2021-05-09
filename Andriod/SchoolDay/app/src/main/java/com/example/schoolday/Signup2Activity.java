package com.example.schoolday;

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

public class Signup2Activity extends AppCompatActivity {

    private EditText firstPhoneNumber, secondPhoneNumber, nationalID, address;
    private RadioButton radioButtonMale, radioButtonFemale;
    private Button signUp;

    private String firstNumberValue, secondNumberValue, nationalIDValue, addressValue;
    private boolean isMale, isFemale, isContinue;

    private static boolean check(String firstNumber, String secondNumber, String nationalID, String address, boolean isMale, boolean isFemale) {
        if (firstNumber.isEmpty() || secondNumber.isEmpty() || nationalID.isEmpty() || address.isEmpty())
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

        firstPhoneNumber = findViewById(R.id.first_phone_number_signup);
        secondPhoneNumber = findViewById(R.id.second_phone_number_signup);
        nationalID = findViewById(R.id.national_identity_number_signUp);
        address = findViewById(R.id.address_signup);
        signUp = findViewById(R.id.signup_button);
        radioButtonMale = findViewById(R.id.radio_male);
        radioButtonFemale = findViewById(R.id.radio_female);

        signUp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                firstNumberValue = firstPhoneNumber.getText().toString();
                secondNumberValue = secondPhoneNumber.getText().toString();
                nationalIDValue = nationalID.getText().toString();
                addressValue = address.getText().toString();
                isMale = radioButtonMale.isChecked();
                isFemale = radioButtonFemale.isChecked();

                //check if the fields empty or not
                isContinue = check(firstNumberValue, secondNumberValue, nationalIDValue, addressValue, isFemale, isMale);

                if (isContinue == true) {

                    //check if the phone is right or not
                    if (Patterns.PHONE.matcher(firstNumberValue).matches() && Patterns.PHONE.matcher(secondNumberValue).matches()
                            && firstNumberValue.length() == 11 && secondNumberValue.length() == 11) {

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