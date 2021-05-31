package com.example.schoolday;

import android.widget.RadioButton;


public class UserRequest {
    private String name;
    private String email;
    private String password;
    private String confirmPassword;
    private RadioButton gender;


    public RadioButton getGender() {
        return gender;
    }

    public void setGender(RadioButton gender) {
        this.gender = gender;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getConfirmPassword() {
        return confirmPassword;
    }

    public void setConfirmPassword(String confirmPassword) {
        this.confirmPassword = confirmPassword;
    }
}
