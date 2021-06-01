package com.example.schoolday;

import android.widget.RadioButton;
import android.widget.RadioGroup;

public class UserResponse {

    private int id;
    private String name;
    private String email;
    private String password;
    private RadioButton gender;

    public RadioButton getGender() {
        return gender;
    }

    public void setGender(RadioButton gender) {
        this.gender = gender;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
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

    private String confirmPassword;
}
